using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP6.Controllers
{
    public class FacturasController : Controller
    {
        public ActionResult CargarFacturas()
        {
            return View();
        }

        public ActionResult CargarDetalle()
        {
            return View();
        }
    }
}