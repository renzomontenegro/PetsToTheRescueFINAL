using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsToTheRescue.Domain.Core.DTOs
{
    public class ClientesDTO
    {
        public int idCliente { get; set; }
        public string? usuario { get; set; }
        public string? nombre { get; set; }
        public string? apellidos { get; set; }
        public string? contrasenia { get; set; }
        public string? numDocumento { get; set; }
        public string? horaMomento { get; set; }
    }

    public class ClientesContraseniaDTO
    {
        public int Id { get; set; }
        public string apellidos { get; set; }
        public string contrasenia { get; set; }

    }

    public class ClientesPostDTO
    {
        public string usuario { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string contrasenia { get; set; }
        public string numDocumento { get; set; }
        public string horaMomento { get; set; }
    }
}
