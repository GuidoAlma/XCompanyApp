using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using XCompanyApp.Models;

namespace XCompanyApp.Repositories
{
    public class TipoPermisoRepository : IRepository<TipoPermiso>
    {
        AppContext context;
        public TipoPermisoRepository(AppContext _context)
        {
            context = _context;
        }

        public IEnumerable<TipoPermiso> GetAll()
        {
            throw new NotImplementedException();
        }

        public TipoPermiso GetById(int id)
        {
            throw new NotImplementedException();
        }

        public TipoPermiso Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}