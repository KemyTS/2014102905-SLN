using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2014102905_API.DTO
{
    public class ClienteDTO
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }

    }
}