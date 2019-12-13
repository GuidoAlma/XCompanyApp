using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XCompanyApp.Repositories
{
    public class PermisosRepository : IRepository<PermisosRepository>
    {
        AppContext context;
        public PermisosRepository(AppContext _context)
        {
            context = _context;
        }
        public IEnumerable<PermisosRepository> GetAll()
        {
            throw new NotImplementedException();
        }

        public PermisosRepository GetById(int id)
        {
            throw new NotImplementedException();
        }

        public PermisosRepository Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}