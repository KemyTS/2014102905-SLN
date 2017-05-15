using _2014102905_ENT.Entities;
using _2014102905_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102905_PER.Repositories
{
    public class ServicioRepository : Repository<Servicio>, IServicioRepository
    {
        private readonly TransporteDbContext _Context;

        private ServicioRepository()
        {

        }

        public ServicioRepository(TransporteDbContext context)
        {
            _Context = context;
        }
    }
}
