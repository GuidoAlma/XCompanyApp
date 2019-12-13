namespace XCompanyApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using XCompanyApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<XCompanyApp.Repositories.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(XCompanyApp.Repositories.AppContext context)
        {
            context.TipoPermiso.AddOrUpdate(
                new TipoPermiso()
                {
                    Descripcion = "Administrador"
                },
                new TipoPermiso()
                {
                    Descripcion = "Usuario"
                },
                new TipoPermiso()
                {
                    Descripcion = "Solo Lectura"
                });
        }
    }
}
