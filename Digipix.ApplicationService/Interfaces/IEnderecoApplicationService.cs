using Digipix.Model;
using System.Threading.Tasks;

namespace Digipix.ApplicationService.Interfaces
{
    public interface IEnderecoApplicationService
    {
        Task<EnderecoModel> GetByZipCode(string zipCode);
    }
}
