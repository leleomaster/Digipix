using Digipix.ApplicationService.Interfaces;
using Digipix.Model;
using System.Threading.Tasks;
using System.Web.Http;

namespace Digipix.API.Controllers
{
    [RoutePrefix("api/Endereco")]    
    public class EnderecoController : ApiController
    {
        private readonly IEnderecoApplicationService _enderecoApplicationService;

        public EnderecoController(IEnderecoApplicationService enderecoApplicationService)
        {
            _enderecoApplicationService = enderecoApplicationService;
        }

        [Route("v0/GetByZipCode/{zipCode}")]
        public async Task<EnderecoModel> GetByZipCode([FromUri] string zipCode)
        {
            return await _enderecoApplicationService.GetByZipCode(zipCode);
        }
    }
}
