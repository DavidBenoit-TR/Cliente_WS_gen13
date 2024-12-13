using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cliente_WS_gen13.Catalogos.Calculadora
{
    public partial class Calculadora : System.Web.UI.Page
    {
        //crear un clinete que resuelva las peticiones del servicio SOAP
        Calculadora_Service.Calculadora_ServiceSoapClient Cliente_WS;
        protected void Page_Load(object sender, EventArgs e)
        {
            //inicilaizo mi cliente SOAP
            Cliente_WS = new Calculadora_Service.Calculadora_ServiceSoapClient();
        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            //recupero los datos del formulario
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            //invoco a mi servicio pasando los datos que se requieran
            double resultado = Cliente_WS.Suma(a, b);
            //muestro el resultado del servicio en mi página
            lblresultado.Text = resultado.ToString();

        }

        protected void btnRestar_Click(object sender, EventArgs e)
        {
            //recupero los datos del formulario
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            //invoco a mi servicio pasando los datos que se requieran
            double resultado = Cliente_WS.Resta(a, b);
            //muestro el resultado del servicio en mi página
            lblresultado.Text = resultado.ToString();
        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //recupero los datos del formulario
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            //invoco a mi servicio pasando los datos que se requieran
            double resultado = Cliente_WS.Multiplicacion(a, b);
            //muestro el resultado del servicio en mi página
            lblresultado.Text = resultado.ToString();
        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            //recupero los datos del formulario
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            //invoco a mi servicio pasando los datos que se requieran
            double resultado = Cliente_WS.Division(a, b);
            //muestro el resultado del servicio en mi página
            lblresultado.Text = resultado.ToString();
        }
    }
}