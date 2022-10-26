using Ejemplo1Asp.Models;
using Ejemplo1Asp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;


namespace Ejemplo1Asp.Controllers
{
    public class OperasBasController : Controller
    {
        // GET: OperasBas
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MuestraPeliculas()
        {
            var PeliculasService = new PeliculasService();
            var model = PeliculasService.ObtenerPelicula();

            return View(model);//Areglo de peliculas las mandamos a la vista
            //Crear un enlace entre la vista y el controlador 
        }

        public ActionResult Sumar()//Se define el objeto de clase
        {
            var tem = new Calculos();
            return View(tem);
        }
        [HttpPost]

        public ActionResult Sumar(Calculos juan, string r1)//Se define el objeto de clase
        {

            var tem = new Calculos();
            tem = juan;
            if (r1.Equals("Sumar"))
            {
                tem.Sumar();
            }
            if (r1.Equals("Restar"))
            {
                tem.Resta();
            }

            ViewBag.res = tem.Resultado;//Crear una variable que podemso utilizar en la vista
            return View();
        }

        public RedirectToRouteResult Temporal()//Content no regresa vistas
        {
            //var alumno1 = new Alumno() { Nombre = "Iza", Edad = 15 };
            //var alumno2 = new Alumno() { Nombre = "Sofia", Edad = 16 };
            //return Json(new List<Alumno>() { alumno1,alumno2},JsonRequestBehavior.AllowGet);

            return RedirectToAction("About","Home");
           
        }
        //public RedirectToRouteResult Temporal(){return RedirectToAction("About","Home")} te redirige a la que pongas en los parametros
       
        public ActionResult vista()
        {
            ViewBag.Nombre = "Sofia";
            ViewData["Nom"] = "Iza";
            return View();
        }
    }
}