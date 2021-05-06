using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace evaluacion1_DarioIrribarra.Models
{
    public class Datos
    {
        public string run { get; set; }
        public string nombre { get; set; }
        public string fono { get; set; }
        public string direccion { get; set; }
        public string comentario { get; set; }
        public string plan { get; set; }
        public string precio_plan { get; set; }

        public void GuardarPlan(Datos d)
        {
            StreamWriter sw = new StreamWriter(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt", true);
            sw.WriteLine(
                "Run Cliente: " + d.run +
                "<br>Nombre Cliente: " + d.nombre +
                "<br>Teléfono: " + d.fono +
                "<br>Dirección: " + d.direccion +
                "<br>Comentario: " + d.comentario +
                "<br>Plan Contratado: " + d.plan +
                "<br>Precio Plan: " + d.precio_plan +
                "<br>"
                );
            sw.Close();
        }

        public string ListarClientes()
        {
            StreamReader sr = new StreamReader(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt");
            string lista = sr.ReadToEnd();
            sr.Close();
            return lista;
        }
    }

    
}