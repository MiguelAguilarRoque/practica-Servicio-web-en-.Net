using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace practica_3
{
    /// <summary>
    /// Descripción breve de calcularareas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class calcularareas : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public string areacuadrado(decimal n1, decimal n2)
        {
            Calculararea c = new Calculararea();
            c.numero1 = n1;
            c.numero2 = n2;
            return Convert.ToString(c.areacuadrado(n1, n2));
        }
        public string areatriangulo(decimal n1, decimal n2)
        {
            Calculararea c = new Calculararea();
            c.numero1 = n1;
            c.numero2 = n2;
            return Convert.ToString(c.areatriangulo(n1, n2));

        }
        public string areacirculo (decimal n1)
        {
            Calculararea c = new Calculararea();
            c.numero1 = n1;
            return Convert.ToString(c.areacirculo(n1));
        }

    }
}
