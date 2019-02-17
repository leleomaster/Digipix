using Digipix.API.Controllers;
using Digipix.ApplicationService.Implementations;
using Digipix.Infrastructure.AutoMapper.Mappers;
using Digipix.Infrastructure.Service.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Digipix.Teste
{
    [TestClass]
    public class EnderecoController_Teste
    {
        EnderecoController _endereco = new EnderecoController(new EnderecoApplicationService(new EnderecoService()));

        [TestInitialize]
        public void Initialize()
        {
            AutoMapper.Mapper.Reset();
            AutoMapperConfig.Run();
        }

        [TestMethod]
        public void CEP_Existe()
        {
            string cep = "03047000";
            
            var result = _endereco.GetByZipCode(cep);

            Assert.IsNotNull(result.Result);
        }

        [TestMethod]
        public void CEP_Nao_Existe()
        {
            string cep = "03459447";

            var result = _endereco.GetByZipCode(cep);

            var endereco = result.Result == null ? null: result.Result.Cidade;

            Assert.IsNull(endereco);
        }
    }
}
