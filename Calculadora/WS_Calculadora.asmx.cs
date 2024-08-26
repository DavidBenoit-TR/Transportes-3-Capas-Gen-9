using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calculadora
{
    /// <summary>
    /// Descripción breve de WS_Calculadora
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Calculadora : System.Web.Services.WebService
    {

        [WebMethod]//decorador (Data Anotations)
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public float Suma(float a, float b)
        {
            return a + b;
        }

        [WebMethod]
        public float Resta(float a, float b)
        {
            return a - b;
        }
        [WebMethod]
        public float Multiplicacion(float a, float b)
        {
            return a * b;
        }
        [WebMethod]
        public float Division(float a, float b)
        {
            return a / b;
        }
    }
}
