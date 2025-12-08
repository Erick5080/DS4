using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_20_2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDimension.Text, out int N) && N > 0)
            {
                if (N > 100)
                {
                    lblMatriz.Text = "<p class='alert alert-warning'>N es muy grande. Se recomienda una dimensión menor a 100.</p>";
                    return;
                }

                StringBuilder sb = new StringBuilder();
                sb.Append("<table class='table table-bordered table-sm' style='width: auto; text-align: center; font-size: 1.2em;'>");

                for (int i = 0; i < N; i++)
                {
                    sb.Append("<tr>");
                    for (int j = 0; j < N; j++)
                    {
                        if (i + j == N - 1)
                        {
                            sb.AppendFormat("<td style='background-color:#cceeff; font-weight:bold;'>1</td>");
                        }
                        else
                        {
                            sb.Append("<td>0</td>");
                        }
                    }
                    sb.Append("</tr>");
                }
                sb.Append("</table>");

                lblMatriz.Text = sb.ToString();
            }
            else
            {
                lblMatriz.Text = "<p class='alert alert-danger'>Por favor, ingrese un número entero positivo (N) para la dimensión de la matriz.</p>";
            }
        }
    }
}