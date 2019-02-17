using Digipix.Domain;
using System.Threading.Tasks;

namespace Digipix.Infrastructure.Service.Interfaces
{
    public interface IEnderecoService
    {
         Task<EnderecoDomain> GetByZipCode(string zipCode);
    }
}
