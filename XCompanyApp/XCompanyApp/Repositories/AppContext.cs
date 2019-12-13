using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using XCompanyApp.Models;

namespace XCompanyApp.Repositories
{
    public class AppContext : DbContext
    {
        public AppContext(): base("AppContext") { }

        public virtual DbSet<Permisos> Permisos { get; set; }

        public virtual DbSet<TipoPermiso> TipoPermiso { get; set; }
    }
}