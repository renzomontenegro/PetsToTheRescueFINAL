using Microsoft.EntityFrameworkCore;
using PetsToTheRescue.Domain.Infrastucture.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsToTheRescue.Domain.Infrastucture.Repositories
{
    public class ClientesRepository : IClientesRepository
    {
        private readonly PetsToTheRescueContext _context;

        public ClientesRepository(PetsToTheRescueContext context)
        {
            _context = context;

        }
        public async Task<IEnumerable<Clientes>> GetClientes()
        {
            return await _context.Clientes.ToListAsync();
        }
        public async Task<Clientes> GetClientesById(int id)
        {
            return await _context.Clientes.Where(x => x.IdCliente == id).FirstOrDefaultAsync();

        }
        public async Task Insert(Clientes customer)
        {
            await _context.Clientes.AddAsync(customer);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> Update(Clientes customer)
        {
            var customerNow = await _context.Clientes.FindAsync(customer.IdCliente);
            customerNow.Usuario = customer.Usuario;
            customerNow.Nombre = customer.Nombre;
            customerNow.Apellidos = customer.Apellidos;
            customerNow.Contrasenia = customer.Contrasenia;
            customerNow.NumDocumento = customer.NumDocumento;

            int countRows = await _context.SaveChangesAsync();
            return (countRows > 0);

        }

        public async Task<bool> Delete(int id)
        {
            var customerNow = await _context.Clientes.FindAsync();
            if (customerNow == null)
                return false;
            _context.Clientes.Remove(customerNow);
            int countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

    }
}
