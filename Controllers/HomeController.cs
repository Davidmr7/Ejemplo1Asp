using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo1Asp.Controllers
{
    public class HomeController : Controller//es como en angular .component 
    {
        public ActionResult Index()//Aciones = funciones 
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "IEVN 1001";//viewbag enviar mensajes a al vista 

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
//misma pagina codifgo de html y c#