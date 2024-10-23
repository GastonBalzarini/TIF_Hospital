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
    public class DaoEspecialidades
    {
        //Se declara una consulta general
        string ConsultaSQLTablaEspecialidades = "SELECT * FROM Especialidades";

        //Se declara un objeto ConexionBD llamado cn
        ConexionBD cn = new ConexionBD();

        //Devuelve un DropDownList cargado con las especialidades
        public DropDownList CargarEspecialidades(DropDownList Lista)
        {
            // Establece la fuente de datos del DropDownList utilizando la tabla "Especialidades"
            // El método cn.ObtenerTabla ejecuta la consulta SQL para obtener los datos
            Lista.DataSource = cn.ObtenerTabla("Especialidades", ConsultaSQLTablaEspecialidades);

            // Especifica el campo de la tabla que se mostrará como texto en el DropDownList
            Lista.DataTextField = "Nombre_ES";

            // Especifica el campo de la tabla que se utilizará como valor del DropDownList
            Lista.DataValueField = "Id_Especialidad_ES";

            // Realiza el enlace de datos para llenar el DropDownList con los datos obtenidos
            Lista.DataBind();

            // Devuelve el DropDownList cargado con las especialidades
            return Lista;
        }


        //Devuelve un DropDownList cargado con las especialidades, empezando por tal especialidad
        public DropDownList CargarEspecialidadessReg(DropDownList Lista, string registro)
        {
            Lista.DataSource = cn.ObtenerTabla("Especialidades", ConsultaSQLTablaEspecialidades + " ORDER BY CASE WHEN Id_Especialidad_ES = '" + registro + "' THEN 0 ELSE 1 END; ");
          
            Lista.DataTextField = "Nombre_ES";
            Lista.DataValueField = "Id_Especialidad_ES";
            Lista.DataBind();

            return Lista;
        }
    }
}
