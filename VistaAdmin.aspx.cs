using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Windows;
using Negocio;

namespace Vistas
{
    public partial class VistaAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Datos Usuario"] != null)
            {
                lblUsuarioLogueado.Text = Session["Datos Usuario"].ToString();
            }

        }

        protected void lbPacientes_Click(object sender, EventArgs e)
        {

        }

        protected void lbMedicos_Click(object sender, EventArgs e)
        {
        }

        protected void lbInicio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estas volviendo a la pagina inicio.");
            

        }
    }

}