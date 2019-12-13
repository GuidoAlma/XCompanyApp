using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCompanyApp.Models;
using XCompanyApp.Repositories;

namespace XCompanyAppTest
{
    [TestClass]
    public class PermisosRepositoryTest
    {
        PermisosRepository repo;

        [TestInitialize]
        public void Initialize()
        {
            var context = new XCompanyApp.Repositories.AppContext();
            repo = new PermisosRepository(context);
        }

        [TestMethod]
        public void AssertCRUDOperations()
        {
            AssertCreate();
            AssertGet();
        }

        private void AssertGet()
        {
            var result = repo.GetAll();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() > 0);
        }

        private void AssertCreate()
        {
            var permisos = new Permisos()
            {
                ApellidosEmpleado = "Alma",
                FechaPermiso = DateTime.UtcNow,
                NombreEmpleado = "Guido",
                TipoPermisoId = 1
            };

            var result = repo.Add(permisos);
            Assert.IsTrue(result.Id > 0);
        }
    }
}
