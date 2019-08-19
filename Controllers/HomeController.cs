using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAngular.Controllers
{
    public class HomeController : Controller
    {
        private Models.PostulacionDBContext postulacionDBContext = new Models.PostulacionDBContext();
        public ActionResult Index()
        {
            var lista = postulacionDBContext.Vehiculos.ToList();

            return View();
        }
    }
}