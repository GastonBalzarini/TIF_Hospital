using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;
using System.Windows;
using System.Data;
using Negocio;


namespace Vistas
{
    public partial class Informes : System.Web.UI.Page
    {
        NegocioTurnos negTurn = new NegocioTurnos();
        NegocioSexo negSex = new NegocioSexo();

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        
            if (Session["Datos Usuario"] != null)
            {
                LblUsuarioLogueado.Text = Session["Datos Usuario"].ToString();
            }
         
            if (!IsPostBack)
            {
                negSex.ObtenerTablaSexo(ddlSexo);
                ddlSexo.Items.Insert(0, "---Seleccionar---");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtPac.Text;
            DataTable tablaRes = negTurn.informePac(dni);

            if (tablaRes.Rows.Count > 0)
            { 
                string paciente = Convert.ToString(tablaRes.Rows[0]["Nombre"]);
            
                string[] series = { "Asistencias", "Inasistencias" };

                int cantPres = Convert.ToInt32(tablaRes.Rows[0]["Inasistencias"]);
                int cantAuse = Convert.ToInt32(tablaRes.Rows[0]["Asistencias"]);
                int[] cantidad = { cantPres, cantAuse };

                //Colores
                InfPaciente.Palette = ChartColorPalette.Pastel;
                //Titulo
                InfPaciente.Titles.Add("Presentismo del paciente: "+paciente);
                for (int i = 0; i < 2 ;i++)
                {
                    Series serie = InfPaciente.Series.Add(series[i]);

                    serie.Label = cantidad[i].ToString();
                    serie.Points.Add(cantidad[i]);
                }
                lblAusentes.Text ="El paciente "+paciente+": tiene "+ cantPres + " asistencias y " + cantAuse + " inasistencias " ;
            }
            else
            {
                lblAusentes.Text = "No hay pacientes con ese DNI";
            }


            txtPac.Text = "";
        }

        protected void ddlSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valorSexo = ddlSexo.SelectedValue;
            DataTable tablaRes = negTurn.informeSe(valorSexo);


            if (tablaRes.Rows.Count > 0) 
            { 
                string sexo = Convert.ToString(tablaRes.Rows[0]["Sexo"]);
                lblAusentesSexo.Text = sexo;

                string[] series = { "Asistencias", "Inasistencias" };

                int cantAuse = Convert.ToInt32(tablaRes.Rows[0]["Asistencias"]);
                int cantPres = Convert.ToInt32(tablaRes.Rows[0]["Inasistencias"]); 
                int[] cantidad = { cantPres, cantAuse };

                //Colores
                infSexo.Palette = ChartColorPalette.Pastel;
                //Titulo
                infSexo.Titles.Add("Presentismo de pacientes del sexo: " + sexo);

                for (int i = 0; i < 2; i++)
                {
                    Series serie = infSexo.Series.Add(series[i]);

                    serie.Label = cantidad[i].ToString();
                    serie.Points.Add(cantidad[i]);
                }
                lblAusentesSexo.Text = "Los pacientes del sexo " + sexo + ": tienen " + cantPres + " asistencias y " + cantAuse + " inasistencias ";
            }
            else
            {
                lblAusentesSexo.Text = "No hay pacientes del sexo buscado";
            }




        }
    }
}