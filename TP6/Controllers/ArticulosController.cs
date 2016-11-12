using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP6.Models;

namespace TP6.Controllers
{
    public class ArticulosController : Controller
    {
        public ActionResult ListadoArticulos()
        {
            List<ArticulosModels> listadoArticulos = new List<ArticulosModels>() {
                new ArticulosModels(1, "Codigo10", "Monitores", 3500),
                new ArticulosModels(1, "Codigo11", "Televisores", 10500),
                new ArticulosModels(1, "Codigo12", "Tablets", 5500),
                new ArticulosModels(1, "Codigo13", "Impresoras", 3500),
                new ArticulosModels(1, "Codigo14", "Microprocesadores", 6500),
                new ArticulosModels(1, "Codigo15", "Motherboards", 1500),
                new ArticulosModels(1, "Codigo16", "Discos Rigidos", 900),
            };

            return View(listadoArticulos);
        }

        public ActionResult EditarArticulos()
        {
            return View();
        }
    }
}