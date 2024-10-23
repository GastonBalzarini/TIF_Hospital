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
    public partial class VistaMedico : System.Web.UI.Page
    {
        NegocioTurnos negTur = new NegocioTurnos();
        NegocioSexo negSex = new NegocioSexo();

        private string usuario;
        private string legajo;
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            if (Session["Datos Usuario"] != null)
            {
                lblUsuarioLogueado.Text = Session["Datos Usuario"].ToString();
                usuario = Session["Datos Usuario"].ToString();
                legajo = obtenerLegajo(usuario);
            }

            if (!IsPostBack)
            {
                mostrarTabla(legajo);
                negSex.ObtenerTablaSexo(ddlSexo);
                ddlSexo.Items.Insert(0, "---Seleccionar---");
            }
        }

        protected void mostrarTabla(string legajo)
        {
            DataTable tabla = negTur.ObtenerTablaTurnos(legajo);
            gvTurnos.DataSource = tabla;
            gvTurnos.DataBind();
        }

        private string obtenerLegajo(string usuario)
        {
            return negTur.obtenerLegajo(usuario);
        }

        // Guarda la asistencia del paciente al turno
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            GridViewRow fila = (GridViewRow)chk.NamingContainer;

            CheckBox cBox = (CheckBox)fila.FindControl("ch_it_asis");

            // Si se marco el check
            if (cBox.Checked)
            {
                string nombre = ((Label)fila.FindControl("lbl_it_Nombre")).Text;
                string dia = ((Label)fila.FindControl("lbl_it_dia")).Text;
                string hora = ((Label)fila.FindControl("lbl_it_hora")).Text;
                string dni = ((Label)fila.FindControl("lbl_it_DNI")).Text;

                MessageBox.Show("Se confirmo la asistencia del paciente: " + nombre, "Advertencia");
                negTur.cambiarAsistencia(legajo, dia, hora, dni);
            }
            //Si se desmarca el check
            else
            {
                string nombre = ((Label)fila.FindControl("lbl_it_Nombre")).Text;
                string dia = ((Label)fila.FindControl("lbl_it_dia")).Text;
                string hora = ((Label)fila.FindControl("lbl_it_hora")).Text;
                string dni = ((Label)fila.FindControl("lbl_it_DNI")).Text;

                MessageBox.Show("Se cancelo la asistencia del paciente: " + nombre, "Advertencia");
                negTur.cambiarAsistencia(legajo, dia, hora, dni);
            }
        }

        protected void gvTurnos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvTurnos.EditIndex = e.NewEditIndex;
            mostrarTabla(legajo);
        }

        protected void gvTurnos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvTurnos.EditIndex = -1;
            mostrarTabla(legajo);
        }

        protected void gvTurnos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Valores necesarios
            string dia = ((Label)gvTurnos.Rows[e.RowIndex].FindControl("lbl_it_dia")).Text;
            string hora = ((Label)gvTurnos.Rows[e.RowIndex].FindControl("lbl_it_hora")).Text;
            string dni = ((Label)gvTurnos.Rows[e.RowIndex].FindControl("lbl_it_DNI")).Text;

            //Obtengo el valor ingresado
            string observacion = ((TextBox)gvTurnos.Rows[e.RowIndex].FindControl("txt_it_obs")).Text;
         
            
            //Actualizar en la base de datos
            negTur.agregarObservacion(legajo, dia, hora, dni, observacion);

            // Salir del modo de edición y actualizar la tabla
            gvTurnos.EditIndex = -1;
            mostrarTabla(legajo);
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtBuscar.Text;
            
            // Cargar en el GV la tabla filtada por DNI
            gvTurnos.DataSource = negTur.buscarPorDni(dni, legajo);
            gvTurnos.DataBind();
            txtBuscar.Text = "";
            ddlSexo.SelectedIndex = 0;
        }

        protected void ddlSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sexo = ddlSexo.SelectedValue;
            
            // Cargar en el GV la tabla filtrada por sexo
            gvTurnos.DataSource = negTur.buscarPorSexo(sexo, legajo);
            gvTurnos.DataBind();
        }

        protected void btnVerTodos_Click(object sender, EventArgs e)
        {
            mostrarTabla(legajo);
            ddlSexo.SelectedIndex = 0;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarMedico.aspx");
        }
    }
}