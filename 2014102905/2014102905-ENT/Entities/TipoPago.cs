﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102905_ENT.Entities
{
    public class TipoPago
    {
        public int TipoPagoId { get; set; }
        public string MetodoPago { get; set; }

        public virtual int VentaId { get; set; }
        public virtual Venta Venta { get; set; }

        public TipoPago()
        {

        }

    }
}
