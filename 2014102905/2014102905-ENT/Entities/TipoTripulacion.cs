﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102905_ENT.Entities
{
    public class TipoTripulacion
    {
        public int TipoTripulacionId { get; set; }
        public string Nombre { get; set; }

        public int TripulacionId { get; set; }
        public Tripulacion Tripulacion { get; set; }
    }
}
