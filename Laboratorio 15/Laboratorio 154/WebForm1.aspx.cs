using System;

namespace Laboratorio_154
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblResultado.Text = string.Empty;
            }
        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            double n1, n2;
            if (!double.TryParse(txtNum1.Text, out n1) || !double.TryParse(txtNum2.Text, out n2))
            {
                lblResultado.Text = "Introduzca dos números válidos.";
                return;
            }

            double suma = n1 + n2;
            lblResultado.Text = "Resultado: " + suma.ToString();
        }
    }
}