using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConversorTemperaturas
{
    public partial class Secundario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConvertir_Click(object sender, EventArgs e)
        {
            txtGradosFarenheit.Text = Termometro.convertirC_F(Convert.ToDouble(txtGradosCentigrados.Text)).ToString();
        }
    }
}