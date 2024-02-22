using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Temperaturas;

namespace ConversorTemperaturas
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblGCent.Attributes.Add("onmouseover","ponerFoco('txtGCent')");
            lblGFar.Attributes.Add("onmouseover", "ponerFoco('txtGFar')");
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtGFar.Text!="" && txtGCent.Text=="") {
                //Convertir de Farenheit a Centígrados 
                //Versión 1
                // txtGCent.Text= ((Convert.ToDouble(txtGFar.Text) -32)*5/9).ToString();

                //Versión 2: Usando la clase estática Termometro
                //txtGCent.Text = Termometro.convertirF_C(Convert.ToDouble(txtGFar.Text)).ToString();

                //Versión3: Usando una clase (clase grados) de una librería (Temperaturas)

                txtGCent.Text = Grados.Far_a_Cent(Convert.ToDouble(txtGFar.Text)).ToString();
            }
            else if (txtGCent.Text!="" && txtGFar.Text=="")
            {
                //Convertir de Centígrados a Farenheit
                //Versión 1
                //txtGFar.Text = ((Convert.ToDouble(txtGCent.Text) * 9 / 5) + 32).ToString();

                //Versión 2: Usando la clase estática Termometro. Podemos usar la calse en múltiples 
                //Formularios dentro del mismo proyecto
                //txtGFar.Text = Termometro.convertirC_F(Convert.ToDouble(txtGCent.Text)).ToString();

                //Versión3: Usando una clase (clase grados) de una librería (Temperaturas)

                txtGFar.Text = Grados.Cent_a_Far(Convert.ToDouble(txtGCent.Text)).ToString();
            }
            else
            {
                LimpiarCuadros();
            }
        }

        private void LimpiarCuadros()
        {
            txtGFar.Text = "";
            txtGCent.Text = String.Empty;
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCuadros();
        }
    }
}