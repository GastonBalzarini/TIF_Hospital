using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Dao
{
    public class DaoLocalidades
    {
        //Se declara una consulta general
        string ConsultaSQLTablaLocalidades = "SELECT * FROM Localidades";

        //Se declara un objeto ConexionBD llamado cn
        ConexionBD cn = new ConexionBD();

        //Devuelve un DropDownList cargado con las localidades
        public DropDownList CargarLocalidades(DropDownList Lista)
        {
            Lista.DataSource = cn.ObtenerTabla("Localidades", ConsultaSQLTablaLocalidades);
            Lista.DataTextField = "Nombre_LO";
            Lista.DataValueField = "Id_Localidades_LO";
            Lista.DataBind();
            
            return Lista;
        }

        //Devuelve un DropDownList cargado con las localidades, que coincidan con una provincia
        public DropDownList CargarLocalidadesReg(DropDownList Lista, string registro)
        {
            string Consulta = $"SELECT Id_Localidades_LO, Nombre_LO FROM Localidades where Id_Provincia_LO ='{registro}'";

            Lista.DataSource = cn.ObtenerTabla("Localidades", Consulta);
            Lista.DataTextField = "Nombre_LO";
            Lista.DataValueField = "Id_Localidades_LO";
            Lista.DataBind();

            return Lista;
        }
    }
}
