using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XCompanyApp.Models;
using XCompanyApp.Repositories;

namespace XCompanyApp.Controllers
{
    public class PermisosController : Controller
    {
        IPermisosRepository permisosRepo;
        ITipoPermisoRepository tipoPermisoRepo;
        public PermisosController()
        {
            var context = new Repositories.AppContext();
            permisosRepo = new PermisosRepository(context);
            tipoPermisoRepo = new TipoPermisoRepository(context);
        }
        // GET: Permisos
        public ActionResult Index()
        {
            var permisos = permisosRepo.GetAll();
            return View(permisos);
        }

        [HttpGet]
        public ActionResult Crear()
        {
            ViewBag.TipoPermisos = tipoPermisoRepo.GetAll();
            return View();
        }

        [HttpPost]
        public JsonResult Crear(string nombre, string apellidos, int tipoPermiso)
        {
            var permisos = new Permisos()
            {
                ApellidosEmpleado = apellidos,
                NombreEmpleado = nombre,
                TipoPermisoId = tipoPermiso,
                FechaPermiso = DateTime.UtcNow
            };
            
            var result = permisosRepo.Add(permisos);

            var success = result.Id > 0;

            return Json(success);
        }
    }
}