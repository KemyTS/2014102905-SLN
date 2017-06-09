using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2014102905_API.DTO
{
    public abstract class ServicioDTO
    {
        public int ServicioId { get; set; }
        public string NombreServicio { get; set; }
        public decimal Tarifa { get; set; }
    }
}