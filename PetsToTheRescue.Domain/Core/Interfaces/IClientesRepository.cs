using PetsToTheRescue.Domain.Infrastucture.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetsToTheRescue.Domain.Infrastucture.Repositories
{
    public interface IClientesRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Clientes>> GetClientes();
        Task<Clientes> GetClientesById(int id);
        Task Insert(Clientes customer);
        Task<bool> Update(Clientes customer);
    }
}