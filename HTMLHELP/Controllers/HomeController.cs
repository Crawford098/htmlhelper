using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLHELP.Models;

namespace HTMLHELP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            

            return View();
        }
        

        [HttpPost]
        public ActionResult About(Formulario ff)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Proceso", ff);
            }
            else
            {
                return View("About");
            }

            
        }

        public ActionResult Proceso(Formulario ff)
        {
            //Formulario f = new Formulario();

            //f.Cedula = int.Parse(Request.Form["Cedula"]);
            //f.Nombre = Request.Form["Nombre"].ToString();
            //f.Apellido = Request.Form["Apellido"];
            //f.Edad = int.Parse(Request.Form["edad"]);
            //f.Telefono = int.Parse(Request.Form["Telefono"]);
            //f.Correo = Request.Form["Correo"];
            //f.Genero = Request.Form["Genero"];

            return View(ff);
        }
    }
}