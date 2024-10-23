using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using Negocio;

namespace Vistas
{
    public partial class Turnos : System.Web.UI.Page
    {
        // Instancias de las clases de negocio para manejar turnos, especialidades, médicos y pacientes.
        NegocioTurnos NT = new NegocioTurnos();
        NegocioEspecialidad NE = new NegocioEspecialidad();
        NegocioMedicos NM = new NegocioMedicos();
        NegocioMedicoXDias NMXD = new NegocioMedicoXDias();
        NegocioPacientes NP = new NegocioPacientes();

        // Método que se ejecuta al cargar la página
        protected void Page_Load(object sender, EventArgs e)
        {
   
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            // Verifica si hay datos del usuario en la sesión y los muestra en un label
            if (Session["Datos Usuario"] != null)
            {
                lblUsuarioLogueado.Text = Session["Datos Usuario"].ToString();
            }

            // Solo llena los dropdowns si es la primera vez que se carga la página
            if (IsPostBack == false)
            {
                LlenarDDLEspYPac();
            }
        }

        // Método para llenar los dropdowns de especialidades y pacientes
        protected void LlenarDDLEspYPac()
        {
            NE.ObtenerTablaEspecialidad(ddlEspecialidad); // Llama al negocio para obtener especialidades
            ddlEspecialidad.Items.Insert(0, new ListItem("--Seleccionar--", "0")); // Agrega una opción de selección

            NP.ObtenerDDlPacientes(ddlPacientes); // Llama al negocio para obtener pacientes
            ddlPacientes.Items.Insert(0, new ListItem("--Seleccionar--", "0")); // Agrega una opción de selección
        }

        // Evento que se ejecuta al cambiar la selección de especialidad
        protected void ddlEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarDDLMedico(); // Llama al método para llenar el dropdown de médicos
        }


        // Método para llenar el dropdown de médicos según la especialidad seleccionada
        protected void LlenarDDLMedico()
        {
            string idespecialidad = ddlEspecialidad.SelectedValue; // Obtiene el valor de la especialidad seleccionada
            NM.ObtenerDDLMedico(ddlMedico, idespecialidad); // Llama al negocio para obtener médicos
            ddlMedico.Items.Insert(0, new ListItem("--Seleccionar--", "0")); // Agrega una opción de selección
        }


        // Evento que se ejecuta al cambiar la selección de médico
        protected void ddlMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarRBLbDias(); // Llama al método para llenar el RadioButtonList de días y horas
            if (rbDiaYHora.Items.Count == 0) // Verifica si no hay días disponibles
            {
                MessageBox.Show("No hay turnos Disponibles!"); // Muestra un mensaje de aviso
            }
        }

        // Método para llenar el RadioButtonList con días y horas disponibles según el médico seleccionado
        protected void LlenarRBLbDias()
        {
            string idMedico = ddlMedico.SelectedValue; // Obtiene el ID del médico seleccionado
            NMXD.ObtenerDias(rbDiaYHora, idMedico); // Llama al negocio para obtener días disponibles
        }

      

        // Método que se ejecuta al hacer clic en el botón "Asignar Turno"
        protected void btnAsignar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                // Revisa los items del RadioButtonList
                foreach (ListItem item in rbDiaYHora.Items)
                {
                    // Si el ítem está seleccionado
                    if (item.Selected)
                    {
                        // Guarda los valores seleccionados
                        string[] values = item.Value.Split(',');// Divide el valor de 'item.Value' en múltiples partes utilizando la coma como delimitador.
                                                                // Cada parte se almacena en el array 'values'.
                        string legajo = values[0];
                        string dia = values[1];
                        DateTime hora = DateTime.Parse(values[2]);

                        string dniPaciente = ddlPacientes.SelectedValue; // Obtiene el DNI del paciente seleccionado

                        // Guarda los valores en la base de datos
                        int fila = NT.InsertarTurno(legajo, dia, hora, dniPaciente);
                        if (fila > 0) // Si se insertó correctamente
                        {
                            MessageBox.Show("Turno Asignado con Éxito!"); // Muestra un mensaje de éxito
                        }
                        else
                        {
                            MessageBox.Show("Error al asignar Turno!"); // Muestra un mensaje de error
                        }
                    }
                }
            }
            // Limpia los campos después de asignar el turno
            ddlEspecialidad.SelectedIndex = 0;
            ddlMedico.SelectedIndex = 0;
            rbDiaYHora.Items.Clear();
            ddlPacientes.SelectedIndex = 0;
        }

        protected void btnVerTurnos_Click(object sender, EventArgs e)
        {
           
            DataTable tabla = NT.ObtenerTablaTurnos();
            gvTurnos.DataSource = tabla;
            gvTurnos.DataBind();
        }

        protected void gvTurnos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvTurnos.PageIndex = e.NewPageIndex;
            DataTable tabla = NT.ObtenerTablaTurnos();
            gvTurnos.DataSource = tabla;
            gvTurnos.DataBind();
        }
    }
}
