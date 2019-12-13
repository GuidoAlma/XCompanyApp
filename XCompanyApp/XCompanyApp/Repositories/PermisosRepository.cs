using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XCompanyApp.Models;

namespace XCompanyApp.Repositories
{
    public class PermisosRepository : IPermisosRepository
    {
        AppContext context;
        public PermisosRepository(AppContext _context)
        {
            context = _context;
        }

        public Permisos Add(Permisos entity)
        {
            context.Permisos.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public IEnumerable<Permisos> GetAll()
        {
            return context.Permisos;
        }

        public Permisos GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Permisos Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}