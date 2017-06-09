using _2014102905_ENT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102905_PER.EntityTypeConfiguration
{
    public class TipoComprobanteConfiguration : EntityTypeConfiguration<TipoComprobante>
    {
        public TipoComprobanteConfiguration()
        {
            //Table configurations
            ToTable("TipoCombrobantes");
            HasKey(c => c.TipoComprobanteId);
            Property(c => c.TipoComprobanteId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.NombreComprobante).IsRequired().HasMaxLength(300);
        }
    }
}
