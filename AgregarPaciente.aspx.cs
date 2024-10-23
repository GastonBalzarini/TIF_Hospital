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
    public partial class AgregarPaciente : System.Web.UI.Page
    {
        // Declaración de instancias de clases de negocio para gestionar pacientes, localidades, nacionalidades, sexo y provincias
        NegocioPacientes neg = new NegocioPacientes();
        NegocioLocalidad negLoc = new NegocioLocalidad();
        NegocioNacionalidad negNac = new NegocioNacionalidad();
        NegocioSexo negSex = new NegocioSexo();
        NegocioProvincia negProv = new NegocioProvincia();

        // Evento que se ejecuta al cargar la página
        protected void Page_Load(object sender, EventArgs e)
        {
            // Verifica si existe una sesión de usuario activa y muestra el nombre de usuario en un label
            if (Session["Datos Usuario"] != null)
            {
                LblUsuarioLogueado.Text = Session["Datos Usuario"].ToString();
            }

            // Configuración para desactivar la validación no intrusiva
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            // comprueba si es la primera vez que se carga la página., llena los DropdownLists (DDLs)
            if (!IsPostBack)
            {
                LlenarDDLs();
            }
        }

        // Método para llenar los DropdownLists con datos de localidades, nacionalidades, provincias y sexo
        protected void LlenarDDLs()
        {
            negLoc.ObtenerTablaLocalidad(ddlLocalidad);
            ddlLocalidad.Items.Insert(0, "--Seleccionar--");
            negNac.ObtenerTablaNacionalidad(ddlNac);
            ddlNac.Items.Insert(0, "---Seleccionar---");
            negProv.ObtenerTablaProvincias(ddlProv);
            ddlProv.Items.Insert(0, "---Seleccionar---");
            negSex.ObtenerTablaSexo(ddlSexo);
            ddlSexo.Items.Insert(0, "---Seleccionar---");
        }

        // Evento que se ejecuta al hacer clic en el botón para agregar paciente
        protected void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            // Variables para almacenar los datos del paciente ingresados por el usuario
            Boolean estado = false;
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string sexo = ddlSexo.SelectedValue;
            string nacionalidad = ddlNac.SelectedValue;
            DateTime fechaNac = DateTime.Parse(txtFechaNac.Text);
            string direccion = txtDireccion.Text;
            string localidad = ddlLocalidad.SelectedValue;
            string provincia = ddlProv.SelectedValue;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;

            // Verifica que el DNI del paciente no exista en la base de datos
            // Si no existe, intenta agregar el paciente
            if (!neg.verificarExistencia(dni))
            {
                estado = neg.agregarPaciente(dni, nombre, apellido, sexo, nacionalidad, fechaNac, direccion, localidad, provincia, correo, telefono);

                lblaviso.Text = localidad;

                // Si se agrega correctamente, muestra un mensaje de confirmación
                if (estado == true)
                {
                    lblaviso.Text = "Paciente agregado!";
                }
            }
            // Si el DNI ya existe, muestra un mensaje de aviso
            else
            {
                lblaviso.Text = "Ya existe un paciente con el DNI: " + dni;

                // Si el paciente está dado de baja, ofrece la opción de recuperarlo
                if (neg.dadoDeBaja(dni))
                {
                    // Implementación para mostrar un MessageBox y confirmar la recuperación del paciente
                    string resultado = (MessageBox.Show("El registro del paciente se encuentra eliminado. ¿Desea recuperarlo?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning)).ToString();
                    if (resultado == "Yes")
                    {
                        neg.altaLogica(dni);
                        MessageBox.Show("Se ha recuperado el registro");
                    }
                }
            }

            // Limpia todos los campos de entrada después de procesar la acción
            LimpiarCampos();
        }

        // Método para llenar la lista de localidades cuando se selecciona una provincia en el DropdownList de provincias
        protected void ddlProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idProvincia = ddlProv.SelectedValue;
            negLoc.ObtenerTablaLocReg(ddlLocalidad, idProvincia);
            ddlLocalidad.Items.Insert(0, "--Seleccionar--");
        }

        // Método para limpiar el mensaje de aviso cuando el texto del DNI cambia
        protected void txtDNI_TextChanged(object sender, EventArgs e)
        {
            lblaviso.Text = "";
        }

        // Método para limpiar todos los campos de entrada después de procesar la acción
        private void LimpiarCampos()
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            ddlSexo.SelectedIndex = 0;
            ddlNac.SelectedIndex = 0;
            txtFechaNac.Text = "";
            txtDireccion.Text = "";
            ddlLocalidad.SelectedIndex = 0;
            ddlProv.SelectedIndex = 0;
            txtCorreo.Text = "";
            txtTelefono.Text = "";
        }
    }
}
