using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;
using System.Data;
using System.Windows;

namespace Vistas
{
    public partial class ModificarMeidco : System.Web.UI.Page
    {
        NegocioAdmYMed neg = new NegocioAdmYMed();
        NegocioMedicos NM = new NegocioMedicos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Datos Usuario"] != null)
            {
                LblUsuarioLogueado.Text = Session["Datos Usuario"].ToString();
            }
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

        }

        protected void btnModificarContra_Click(object sender, EventArgs e)
        {
       
            string contraseñanueva = txtContraseña.Text;
            string contraseña2 = txtContraseña2.Text;

            if(contraseñanueva == contraseña2) {
                bool estado = neg.modificarMedico(LblUsuarioLogueado.Text.ToString(), contraseñanueva);

          
                    if (estado)
                    {
                        lblAviso.Text = "Medico modificado con exito";
                    }
                    else
                    {
                        lblAviso.Text = "El medico no pudo ser modificado";
                    }
                
            }
            else
            {
                lblAviso.Text = "Las contraseñas no coinciden";
            }


            txtContraseña.Text = "";
            txtContraseña2.Text = "";
        }

        protected void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            string UsuarioNuevo = txtUsuarioNuevo.Text;
            string Usuario2 = txtRepUsuario.Text;

            string Legajo = NM.BuscarLegajo(LblUsuarioLogueado.Text.ToString());
            
            if (UsuarioNuevo == Usuario2)
            {
                bool estado = neg.modificarUsuario(UsuarioNuevo,Legajo);


                if (estado)
                {
                    lblAviso.Text = "Usuario modificado con exito";
                }
                else
                {
                    lblAviso.Text = "El Usuario no pudo ser modificado";
                }

            }
            else
            {
                lblAviso.Text = "Los Usuarios no coinciden";
            }


            txtUsuarioNuevo.Text = "";
            txtRepUsuario.Text = "";
        }
    }
}