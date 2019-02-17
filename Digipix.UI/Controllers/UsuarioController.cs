using Digipix.ApplicationService.Interfaces;
using System.Web.Mvc;

namespace Digipix.UI.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IEnderecoApplicationService _enderecoApplicationService;

        public UsuarioController(IEnderecoApplicationService enderecoApplicationService)
        {
            _enderecoApplicationService = enderecoApplicationService;
        }

        public ActionResult Cadastrar()
        {
            return View();
        }
    }
}