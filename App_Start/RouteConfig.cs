using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ejemplo1Asp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)//metodo que se le pasa una clase 
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");//colecciones 
            //maps permiten almacenar como si fueran objetos 

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",// controlador o (/) accion 
                defaults: new { controller = "OperasBas", action = "Sumar", id = UrlParameter.Optional }//PasR UN NOMBRE DE CONTROLADOR y el id puede ser opcional
            );
        }
    }
}
