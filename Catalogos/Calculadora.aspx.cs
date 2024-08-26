using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Transportes_3_Capas_Gen_9.WS_Calculadora;

namespace Transportes_3_Capas_Gen_9.Catalogos
{
    public partial class Calculadora : System.Web.UI.Page
    {
        //Variables Globales: Digase de aquellas variables que estarán disponibles y son accesibles desde cualquier parte del Código subyacente (mismo documento)
        //Creamo sun objeto del tipo "WS_CalculadoraSoapClient" que representa a forma de clase la relación existente entre mi proyecto Web (Transportes 3 capas) y mi Servicio WEB (Calculadora WS)
        //Crear un CLiente que resuelva las peticiones del Servicio SOAP
        WS_CalculadoraSoapClient cliente_WS;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Se crea una Instancia del obnjeto para poder trabajar con él
            //Instancia DEF.
            //Instancia es un término que se usa en la programación orientada a objetos para referirse a un objeto que se deriva de otro.Una instancia es una copia de una clase de programación que tiene sus propios atributos y métodos.Todos los objetos son instancias de algún otro, excepto la clase Object que es la clase base de todas.
            //Inicializo mi cliente SOAP
            cliente_WS = new WS_CalculadoraSoapClient();
        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            //Recupero los datos de mi formulario
            float a = float.Parse(txta.Text);
            float b = float.Parse(txtb.Text);
            //Invoco a mi servicio pasándole los datos que requiere
            float resultado = cliente_WS.Suma(a, b);
            //Muestro el resultado en mi Label
            lblresultado.Text = resultado.ToString();
        }

        protected void btnRestar_Click(object sender, EventArgs e)
        {
            //Recupero los datos de mi formulario
            float a = float.Parse(txta.Text);
            float b = float.Parse(txtb.Text);
            //Invoco a mi servicio pasándole los datos que requiere
            float resultado = cliente_WS.Resta(a, b);
            //Muestro el resultado en mi Label
            lblresultado.Text = resultado.ToString();
        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //Recupero los datos de mi formulario
            float a = float.Parse(txta.Text);
            float b = float.Parse(txtb.Text);
            //Invoco a mi servicio pasándole los datos que requiere
            float resultado = cliente_WS.Multiplicacion(a, b);
            //Muestro el resultado en mi Label
            lblresultado.Text = resultado.ToString();
        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            //Recupero los datos de mi formulario
            float a = float.Parse(txta.Text);
            float b = float.Parse(txtb.Text);
            //Invoco a mi servicio pasándole los datos que requiere
            float resultado = cliente_WS.Division(a, b);
            //Muestro el resultado en mi Label
            lblresultado.Text = resultado.ToString();
        }
    }
}