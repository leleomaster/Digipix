using Digipix.ApplicationService.Interfaces;
using Digipix.Domain;
using Digipix.Infrastructure.AutoMapper.Mappers;
using Digipix.Infrastructure.Logging;
using Digipix.Infrastructure.Service.Interfaces;
using Digipix.Model;
using System;
using System.Threading.Tasks;

namespace Digipix.ApplicationService.Implementations
{
    public class EnderecoApplicationService : IEnderecoApplicationService
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoApplicationService(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        public async Task<EnderecoModel> GetByZipCode(string zipCode)
        {
            EnderecoModel enderecoModel = null;
            try
            {
                EnderecoDomain enderecoDoamin = await _enderecoService.GetByZipCode(zipCode);
                
                return EnderecoMapper.DomainToModelView(enderecoDoamin);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "GetByZipCode");
            }
            return enderecoModel;
        }
    }
}
