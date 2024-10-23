using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Vistas
{
    public partial class Inicio : System.Web.UI.Page
    {
        ///Objetos para de dichas clases para poder usar sus metodos y funciones
        Administradores_Y_Medicos obj = new Administradores_Y_Medicos();
        NegocioClinica NC = new NegocioClinica();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ///uso el obj para guardar los datos ingresados por el usuario
            obj.Usuario1 = txtNombreUsuario.Text;
            obj.Contraseña1 = txtConstraseña.Text;
            obj.Tipo1 = rblTipo.SelectedValue;
            ///Se llamara una funcion de la capa Negocio para verificar que los datos esten registrados en la base de datos
            ///tomando en cuenta lo que se guardo en el obj
            Boolean Verificar =  NC.BuscarUsuario(obj);
            ///Se devolvera un true si los datos se encuentran
            if (Verificar)
            {
                ///el nombre de usuario se guardara en una session para despues mostrarse en los siguientes formularios
                Session["Datos Usuario"] = obj.Usuario1;
                txtNombreUsuario.Text = "";
                if (rblTipo.SelectedValue == "Medico")
                {
                    Response.Redirect("VistaMedico.aspx");
                }
                else
                {
                    Response.Redirect("vistaAdmin.aspx");
                }
            }
            lblAviso.Text = "Usuario invalidado. Ingrese Nuevamente";
            txtNombreUsuario.Text = "";

        }
    }
}