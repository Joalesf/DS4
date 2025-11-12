using System;
using System.Web.UI;

namespace Laboratorio_15_4
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;

            // Validar que los textos sean números
            if (double.TryParse(TextBox1.Text, out numero1) && double.TryParse(TextBox2.Text, out numero2))
            {
                resultado = numero1 + numero2;
                Label4.Text = resultado.ToString();
            }
            else
            {
                Label4.Text = "Error: Ingrese números válidos";
            }
        }
    }
}
