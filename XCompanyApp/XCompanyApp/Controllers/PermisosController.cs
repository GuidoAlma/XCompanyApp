using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XCompanyApp.Repositories;

namespace XCompanyApp.Controllers
{
    public class PermisosController : Controller
    {
        IPermisosRepository permisosRepo;
        public PermisosController()
        {
            permisosRepo = new PermisosRepository(new Repositories.AppContext());
        }
        // GET: Permisos
        public ActionResult Index()
        {
            var permisos = permisosRepo.GetAll();
            return View(permisos);
        }
    }
}