﻿using _2014102905_ENT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102905_PER.EntityTypeConfiguration
{
    public class TipoLugarConfiguration : EntityTypeConfiguration<TipoLugar>
    {
        public TipoLugarConfiguration()
        {
            //Table configurations
            ToTable("TipoLugares");
            HasKey(c => c.TipoLugarId);
            Property(c => c.TipoLugarId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.NombreTipo).IsRequired().HasMaxLength(300);
        }
    }
}
