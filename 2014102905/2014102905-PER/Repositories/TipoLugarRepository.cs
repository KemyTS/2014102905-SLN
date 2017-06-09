using _2014102905_ENT.Entities;
using _2014102905_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102905_PER.Repositories
{
    public class TipoLugarRepository : Repository<TipoLugar>, ITipoLugarRepository
    {
        public TipoLugarRepository(DbContext context) : base(context)
        {
        }

    }
}
