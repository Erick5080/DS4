using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_20_1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<table class='table table-bordered table-striped'>");
                sb.Append("<thead><tr><th>Multiplicación</th><th>Resultado</th></tr></thead>");
                sb.Append("<tbody>");

                for (int i = 1; i <= 25; i++)
                {
                    int resultado = numero * i;

                    sb.Append("<tr>");
                    sb.AppendFormat("<td>{0} &times; {1} =</td>", numero, i);
                    sb.AppendFormat("<td><strong>{0}</strong></td>", resultado);
                    sb.Append("</tr>");
                }

                sb.Append("</tbody>");
                sb.Append("</table>");

                lblResultado.Text = sb.ToString();
            }
            else
            {
                lblResultado.Text = "<p class='alert alert-danger'>Por favor, ingrese un número entero válido.</p>";
            }
        }
    }
}