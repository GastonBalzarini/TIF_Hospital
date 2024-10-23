using System;
using System.Data;
using Negocio;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Vistas
{
    public partial class Medicos : System.Web.UI.Page
    {
        NegocioProvincia negProv = new NegocioProvincia();
        NegocioEspecialidad negEsp = new NegocioEspecialidad();
        NegocioMedicos negMed = new NegocioMedicos();
        NegocioSexo negSe = new NegocioSexo();
        NegocioLocalidad negLoc = new NegocioLocalidad();
        NegocioNacionalidad negNac = new NegocioNacionalidad();

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            if (Session["Datos Usuario"] != null)
            {
                LblUsuarioLogueado.Text = Session["Datos Usuario"].ToString();
            }
            if (!IsPostBack)
            {
                LlenarDDLProvincias();
                LlenarDDLEspecialidades();
                mostrarTabla();
            }
        }

        protected void LlenarDDLProvincias()
        {
            negProv.ObtenerTablaProvincias(ddlProvincias);
            ddlProvincias.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
        }

        protected void LlenarDDLEspecialidades()
        {
            negEsp.ObtenerTablaEspecialidad(ddlEspecialidades);
            ddlEspecialidades.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
        }

        protected void mostrarTabla(string sexo = null, string provincia = null, string especialidad = null)
        {
            ViewState["SexoSeleccionado"] = sexo;
            ViewState["ProvinciaSeleccionada"] = provincia;
            ViewState["EspecialidadSeleccionada"] = especialidad;

            DataTable tabla;

            if (!string.IsNullOrEmpty(sexo))
            {
                tabla = negMed.BuscarMedxSexo(sexo);
            }
            else if (!string.IsNullOrEmpty(provincia))
            {
                tabla = negMed.buscarMedxProvincia(provincia);
            }
            else if (!string.IsNullOrEmpty(especialidad))
            {
                tabla = negMed.buscarMedXEspecialidad(especialidad);
            }
            else
            {
                tabla = negMed.ObtenerTablaMedicos();
            }

            gvMedicos.DataSource = tabla;
            gvMedicos.DataBind();
        }

        protected void btnVerTodos_Click(object sender, EventArgs e)
        {
            ddlEspecialidades.SelectedIndex = 0;
            ddlProvincias.SelectedIndex = 0;
            mostrarTabla();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ddlEspecialidades.SelectedIndex = 0;
            ddlProvincias.SelectedIndex = 0;
            if (string.IsNullOrWhiteSpace(txtBuscarMed.Text))
            {
                lblaviso.Text = "Debe ingresar un texto";
                return;
            }
            else
            {
                lblaviso.Text = "";
            }
            string texto = txtBuscarMed.Text;

           

            gvMedicos.DataSource = negMed.BuscarMed(texto);
            gvMedicos.DataBind();
         
            txtBuscarMed.Text = "";
        }

        protected void rbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sexoSeleccionado = rbSexo.SelectedValue;
            mostrarTabla(sexoSeleccionado, null, null);
        foreach(ListItem item in rbSexo.Items)
            {
                item.Selected = false; // Deseleccionar todas las opciones
            }
            ddlEspecialidades.SelectedIndex = 0;
            ddlProvincias.SelectedIndex = 0;
        }

        protected void ddlProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string provinciaSeleccionada = ddlProvincias.SelectedValue;
            mostrarTabla(null, provinciaSeleccionada,null);
            ddlEspecialidades.SelectedIndex = 0;
            foreach (ListItem item in rbSexo.Items)
            {
                item.Selected = false; // Deseleccionar todas las opciones
            }
            ddlProvincias.SelectedIndex = 0;
        }

        protected void ddlEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            string especialidadSeleccionada = ddlEspecialidades.SelectedValue;
            mostrarTabla(null,null, especialidadSeleccionada);
            ddlProvincias.SelectedIndex = 0;
            ddlEspecialidades.SelectedIndex = 0;
            foreach (ListItem item in rbSexo.Items)
            {
                item.Selected = false; // Deseleccionar todas las opciones
            }
        }

        protected void gvMedicos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowState.HasFlag(DataControlRowState.Edit))
            {
                DataRowView rowView = e.Row.DataItem as DataRowView;
                if (rowView != null)
                {
                    DropDownList DDLS = e.Row.FindControl("dllElegirSexo") as DropDownList;
                    DropDownList DDLN = e.Row.FindControl("dllElegirNacionalidad") as DropDownList;
                    DropDownList DDLL = e.Row.FindControl("dllElegirLocalidad") as DropDownList;
                    DropDownList DDLP = e.Row.FindControl("dllElegirProvincia") as DropDownList;
                    DropDownList DDLE = e.Row.FindControl("dllElegirEspecialidad") as DropDownList;

                    string seAct = ((Label)e.Row.FindControl("lbl_ed_it_sexo")).Text;
                    string nacAct = ((Label)e.Row.FindControl("lbl_ed_it_Nac")).Text;
                    string locAct = ((Label)e.Row.FindControl("lbl_ed_it_Loc")).Text;
                    string provAct = ((Label)e.Row.FindControl("lbl_ed_it_Prov")).Text;
                    string espAct = ((Label)e.Row.FindControl("lbl_ed_it_Esp")).Text;


                    if (DDLS != null && DDLN != null && DDLL != null && DDLP != null && DDLE != null)
                    {
                        negSe.ObtenerTablaSeReg(DDLS, seAct);
                        negNac.ObtenerTablaNacReg(DDLN, nacAct);
                        negProv.ObtenerTablaProvincias(DDLP);
                        negEsp.ObtenerTablaEspReg(DDLE, espAct);
                    }
                }
            }
        }

        protected void gvMedicos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvMedicos.EditIndex = e.NewEditIndex;
            // Mantener la página actual
            if (ViewState["PageIndex"] != null)
            {
                gvMedicos.PageIndex = (int)ViewState["PageIndex"];
            }
            mostrarTabla((string)ViewState["SexoSeleccionado"], (string)ViewState["ProvinciaSeleccionada"], (string)ViewState["EspecialidadSeleccionada"]);
        }

        protected void gvMedicos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvMedicos.EditIndex = -1;
            mostrarTabla((string)ViewState["SexoSeleccionado"], (string)ViewState["ProvinciaSeleccionada"], (string)ViewState["EspecialidadSeleccionada"]);
        }

        protected void gvMedicos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string legajo = ((Label)gvMedicos.Rows[e.RowIndex].FindControl("lblLegajo")).Text;
            string nombre = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txtNombre")).Text;
            string apellido = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txtApellido")).Text;

            DropDownList DDLS = gvMedicos.Rows[e.RowIndex].FindControl("dllElegirSexo") as DropDownList;
            string sexo = DDLS.SelectedValue;

            DropDownList DDLN = gvMedicos.Rows[e.RowIndex].FindControl("dllElegirNacionalidad") as DropDownList;
            string nacionalidad = DDLN.SelectedValue;

            string direccion = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txtDireccion")).Text;

            DropDownList DDLL = gvMedicos.Rows[e.RowIndex].FindControl("dllElegirLocalidad") as DropDownList;
            string localidad = DDLL.SelectedValue;

            DropDownList DDLP = gvMedicos.Rows[e.RowIndex].FindControl("dllElegirProvincia") as DropDownList;
            string provincia = DDLP.SelectedValue;

            string correoElectronico = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txtCorreoElectronico")).Text;
            string telefono = ((TextBox)gvMedicos.Rows[e.RowIndex].FindControl("txtTelefono")).Text;

            DropDownList DDLE = gvMedicos.Rows[e.RowIndex].FindControl("dllElegirEspecialidad") as DropDownList;
            string especialidad = DDLE.SelectedValue;

            Entidades.Medicos medico = new Entidades.Medicos();
            medico.setLegajo_MED(legajo);
            medico.setNombre_MED(nombre);
            medico.setApellido_MED(apellido);
            medico.setId_Sexo_MED(sexo);
            medico.setId_Nacionalidad_MED(nacionalidad);
            medico.setDireccion_MED(direccion);
            medico.setCod_Localidad_MED(localidad);
            medico.setCod_Provincia_MED(provincia);
            medico.setCorreo_Electronico_MED(correoElectronico);
            medico.setTelefono_MED(telefono);
            medico.setId_Especialidad_MED(especialidad);

            negMed.Actualizar(medico);

            gvMedicos.EditIndex = -1;
            mostrarTabla((string)ViewState["SexoSeleccionado"], (string)ViewState["ProvinciaSeleccionada"], (string)ViewState["EspecialidadSeleccionada"]);
        }

        protected void gvMedicos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eventoEliminar")
            {
                int fila = Convert.ToInt32(e.CommandArgument);
                string LEG = ((Label)gvMedicos.Rows[fila].FindControl("lblLegajo")).Text;

                if (MessageBox.Show("Desea eliminar el registro?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    negMed.BajaLogica(LEG);
                    mostrarTabla((string)ViewState["SexoSeleccionado"], (string)ViewState["ProvinciaSeleccionada"], (string)ViewState["EspecialidadSeleccionada"]);
                }
            }
        }

        protected void gvMedicos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvMedicos.PageIndex = e.NewPageIndex;
            mostrarTabla((string)ViewState["SexoSeleccionado"], (string)ViewState["ProvinciaSeleccionada"], (string)ViewState["EspecialidadSeleccionada"]);
        }

        protected void dllElegirProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList DDLP = sender as DropDownList;
            GridViewRow row = (GridViewRow)DDLP.NamingContainer;
            string provincia = DDLP.SelectedValue;

            if (provincia != "0")
            {
                DropDownList DDLL = row.FindControl("dllElegirLocalidad") as DropDownList;
                negLoc.ObtenerTablaLocReg(DDLL, provincia);
            }
        }
    


        protected void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarMedico.aspx");
        }
    }
}
