using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using Entidades;
using Negocio;

namespace Vistas
{
    public partial class AgregarMedico : System.Web.UI.Page
    {

        NegocioMedicos nm = new NegocioMedicos();
        Medicos med = new Medicos();
        NegocioEspecialidad negEsp = new NegocioEspecialidad();
        NegocioLocalidad negLoc = new NegocioLocalidad();
        NegocioNacionalidad negNac = new NegocioNacionalidad();
        NegocioSexo negSex = new NegocioSexo();
        NegocioProvincia negProv = new NegocioProvincia();
        NegocioAdmYMed negAyM = new NegocioAdmYMed();
        NegocioMedicoXDias NMXD = new NegocioMedicoXDias();

        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["Datos Usuario"] != null)
            {
                LblUsuarioLogueado.Text = Session["Datos Usuario"].ToString();
            }
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            if (!IsPostBack)
            {
                LlenarDDLs();
                lblMensajeDA.Text = "";
            }
        }


        protected void LlenarDDLs()
        {
            negEsp.ObtenerTablaEspecialidad(ddlEspecialidad);
            ddlEspecialidad.Items.Insert(0, "---Seleccionar---");
            negLoc.ObtenerTablaLocalidad(ddlLocalidad);
            ddlLocalidad.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
            negNac.ObtenerTablaNacionalidad(ddlNac);
            ddlNac.Items.Insert(0, "---Seleccionar---");
            negProv.ObtenerTablaProvincias(ddlProv);
            ddlProv.Items.Insert(0, "---Seleccionar---");
            negSex.ObtenerTablaSexo(ddlSexo);
            ddlSexo.Items.Insert(0, "---Seleccionar---");
        }


        protected void btnAgregarUuario_Click(object sender, EventArgs e)
        {
            string usuario = txtNuevoUsuario.Text;
            string contra = txtContrasenia.Text;
            string tipousuario = "Medico";

            // Guarda el usuario en la sesión para su uso posterior
            Session["Usuario"] = usuario;

            // Revisa si el usuario ya existe en la base de datos
            if (negAyM.verificarExistencia(usuario))
            {
                lblAvisoUsuario.Text = "El nombre de usuario ya está en uso. Prueba con otro.";
                txtNuevoUsuario.Text = "";

            }
            else
            {
                // Si no existe, agrega al usuario en la base de datos
                bool resultado = negAyM.agregarUsuario(usuario, contra, tipousuario);
                if (resultado)
                {
                    lblAvisoUsuario.Text = "Usuario nuevo agregado.";
                }
                else
                {
                    lblAvisoUsuario.Text = "Error al agregar el usuario. Inténtalo de nuevo.";
                }

            }
            Session["Usuario"] = usuario;

            // Limpiar el campo de texto del nombre de usuario
            txtNuevoUsuario.Text = "";
        }

        protected void ddlProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idProvincia = ddlProv.SelectedValue;

            negLoc.ObtenerTablaLocReg(ddlLocalidad, idProvincia);
            ddlLocalidad.Items.Insert(0, "--Seleccionar--");
        }

        //Agrega el medico a la base de datos
        protected void btnAgregarMedico_Click(object sender, EventArgs e)
        {
  
            //Guarda los valores ingresados en el formulario en variables
            string sexo = ddlSexo.SelectedValue;
            string legajo = txtLegajo.Text;
            Session["LegajoMedico"] = legajo;
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nacionalidad = ddlNac.SelectedValue;
            DateTime fechaNacimiento = DateTime.Parse(txtFechaNac.Text);
            string direccion = textDomicilio.Text;
            string localidad = ddlLocalidad.SelectedValue;
            string provincia = ddlProv.SelectedValue;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            string especialidad = ddlEspecialidad.SelectedValue;
            string usuario = Session["Usuario"].ToString();
            string tipousuario = "Medico";
                     
            
            //verifica que no exista el legajo en la base de datos
            //Si no existe guarda en la base de datos
            if (nm.verificarExistencia(legajo))
            {
                lblAviso.Text = "El legajo ingresado ya existe.";
              
            }
            else
            {
               bool estado = nm.agregarMedico(legajo, dni, nombre, apellido, sexo, nacionalidad, fechaNacimiento,
                                          direccion, localidad, provincia, correo, telefono, especialidad, usuario, tipousuario);
               
                if (estado)
                { 
                    lblAviso.Text = "Medico ingresado correctamente."; 
                }
                else { lblAviso.Text = "Error al ingresar Medico!"; }
            }

            txtLegajo.Text = "";
            txtDNI.Text = "";
            ddlEspecialidad.SelectedIndex = 0;
            ddlNac.SelectedIndex = 0;
            ddlLocalidad.SelectedIndex = 0;
            ddlProv.SelectedIndex = 0;
            ddlSexo.SelectedIndex = 0;
            txtNombre.Text = "";
            txtNuevoUsuario.Text = "";
            txtApellido.Text = "";
            txtFechaNac.Text = "";
            textDomicilio.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
        }

      

        //Carga el usuario nuevo en la base de datos
      

        /* ESTA FUNCION AGREGA CADA DIA SELECCIONADO EL EL CHECHBOXLIST MAS LAS HORAS DE ATENCION DELDIA DE 8 A 17 POR CADA DIA SELECCIONADO*/
        protected void btnAgregarDias_Click(object sender, EventArgs e)
        {
            int cantFilas = 0;
            int cantItem = 0;
            string legajo = Session["LegajoMedico"] as string;

            // Obtener fecha actual para los horarios
            DateTime fechaActual = DateTime.Today;

            // Recorrer los elementos seleccionados del CheckBoxList
            foreach (ListItem item in chkDias.Items)
            {
                if (item.Selected)
                {
                    // Agregar las horas de 8 am a 5 pm para el día seleccionado
                    for (int hora = 8; hora <= 17; hora++) // 8 am to 5 pm (24-hour format)
                    {
                        DateTime horario = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, hora, 0, 0);

                        // Crear el objeto Medicos_X_Dias y agregar a la base de datos
                        Medicos_X_Dias obj = new Medicos_X_Dias
                        {
                            Legajo1 = legajo,
                            Dia1 = item.Value,
                            Hora = fechaActual.Date.Add(horario.TimeOfDay) // Combina la fecha actual con el componente de tiempo
                        };

                        cantFilas += NMXD.AgregarDiasAtencion(obj);
                    }
                    cantItem++; // Contar los días seleccionados
                }
            }

            // Verificar si se agregaron todas las filas esperadas
            if (cantFilas == cantItem * 10) // 10 horas por cada día seleccionado (de 8 am a 5 pm)
            {
                lblMensajeDA.Text = "Días de Atención agregados correctamente!";
            }
            else
            {
                lblMensajeDA.Text = "No se han podido ingresar los días de atención.";
            }

            chkDias.ClearSelection();
        }

    }
}

