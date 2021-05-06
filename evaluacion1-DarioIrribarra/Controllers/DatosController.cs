using evaluacion1_DarioIrribarra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace evaluacion1_DarioIrribarra.Controllers
{
    public class DatosController : Controller
    {

        public ActionResult Planes()
        {
            return View();
        }

        public ActionResult Guardar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Guardar(Datos d)
        {
            Datos datos = new Datos();
            datos.GuardarPlan(d);
            return View();
        }

        public ActionResult MostrarDatos()
        {
            Datos datos = new Datos();
            string lista = datos.ListarClientes();
            ViewData["listarClientes"] = lista;
            return View();
        }
    }
}