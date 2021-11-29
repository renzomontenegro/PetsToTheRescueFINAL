using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetsToTheRescue.Domain.Core.DTOs;
using PetsToTheRescue.Domain.Infrastucture.Data;
using PetsToTheRescue.Domain.Infrastucture.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetsToTheRescue.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClientesRepository _clientesRepository;
        private readonly IMapper _mapper;
        public ClientesController(IClientesRepository customerRepository, IMapper mapper)
        {
            _clientesRepository = customerRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetClientes")]
        public async Task<IActionResult> GetClientes()
        {
            var clientes = await _clientesRepository.GetClientes();
            var customersList = _mapper.Map<IEnumerable<ClientesDTO>>(clientes);

            return Ok(customersList);

        }

        [HttpGet]
        [Route("GetClientesById/{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var customer = await _clientesRepository.GetClientesById(id);
            if (customer == null)
                return NotFound();
            var customerDTO = _mapper.Map<ClientesDTO>(customer);
            return Ok(customerDTO);
        }


        [HttpPost]
        [Route("PostClientes")]
        public async Task<IActionResult> PostClientes(ClientesPostDTO clientesDTO)
        {
            var customer = _mapper.Map<Clientes>(clientesDTO);
            await _clientesRepository.Insert(customer);
            return Ok(customer.IdCliente);
        }

        [HttpPut]
        [Route("PutClientes")]
        public async Task<IActionResult> PutClientes(ClientesDTO clientesDTO)
        {
            var customer = _mapper.Map<Clientes>(clientesDTO);
            await _clientesRepository.Update(customer);
            return Ok(customer.IdCliente);
        }

        [HttpDelete]
        [Route("DeleteClientes")]
        public async Task<IActionResult> DeleteClientes(int id)
        {
            var result = await _clientesRepository.Delete(id);
            if (!result)
                return NotFound();

            return NoContent();
        }
    }
}
