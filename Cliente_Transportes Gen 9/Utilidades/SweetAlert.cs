using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Cliente_Transportes_Gen_9.Utilidades
{
    public class SweetAlert
    {
        //Método que ejecutará e incrustará un script dentro de nuestra página
        public static void Sweet_Alert(string title, string msg, string type, Page pg, Object obj)
        {
            //Declaración del script
            string sp = "<script languaje='javascript'>" +
                "Swal.fire({" +
                "title: '" + title + "'," +
                "text: '" + msg + "'," +
                "icon: '" + type + "'" +
                "});" +
                "</script>";

            string sp2 = "<script languaje='javascript'>" +
                "Swal.fire({" +
                $"title: '{title}'," +
                $"text: '{msg}'," +
                $"icon: '{type}'" +
                "});" +
                "</script>" +
                "<h1>Sweel Alert</h1>";
            //Type hace referencia al tipo de objeto que voy a trabajar
            Type cstype = obj.GetType();
            //ClientScriptManager me ayuda a incrustar bloques de código de JS en tiempo real
            ClientScriptManager cs = pg.ClientScript;
            //Funciona como una "Pala", abre el código HTML resultante del ASP e incrusta el script de JS para que se ejecute
            cs.RegisterClientScriptBlock(cstype, sp2, sp2);
        }
    }
}