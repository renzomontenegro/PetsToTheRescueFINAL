using AutoMapper;
using PetsToTheRescue.Domain.Core.DTOs;
using PetsToTheRescue.Domain.Infrastucture.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsToRescue.Domain.Infrastucture.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Clientes, ClientesDTO>();
            CreateMap<ClientesDTO, Clientes>();
            CreateMap<ClientesContraseniaDTO, Clientes>();
            CreateMap<Clientes, ClientesContraseniaDTO>();
            CreateMap<ClientesPostDTO, Clientes>();
            CreateMap<Clientes, ClientesPostDTO>();
        }
    }
}
