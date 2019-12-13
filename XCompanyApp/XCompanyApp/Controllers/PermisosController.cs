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

            bool success;

            if (IsValidModel<Permisos>(permisos))
            {
                var result = permisosRepo.Add(permisos);
                success = result.Id > 0;
            }
            else
            {
                success = false;
            }            

            return Json(success);
        }

        private bool IsValidModel<T>(T model)
        {
            ModelState.Clear();
            TryValidateModel(model);
            return !AreModelErrors();
        }

        private bool AreModelErrors()
        {
            
            var errorList = ModelState
                         .Where(x => x.Value.Errors.Count > 0)
                         .ToDictionary(
                             kvp => kvp.Key,
                             kvp => kvp.Value.Errors.Select(e =>
                             e.ErrorMessage).ToArray()
                         );

            return errorList.Count() > 0;
        }

        public ActionResult TipoPermisos()
        {
            var tipoPermisos = tipoPermisoRepo.GetAll();
            return View(tipoPermisos);
        }

        public JsonResult DeleteTipoPermiso(int id)
        {
            var tipoPermiso = tipoPermisoRepo.Remove(id);

            var success = tipoPermiso != null;

            return Json(success, JsonRequestBehavior.AllowGet);
        }
    }
}