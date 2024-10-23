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
    public class DaoNacionalidad
    {
        string ConsultaSQLTablaLocalidades = "SELECT * FROM Nacionalidad";
        ConexionBD cn = new ConexionBD();

        public DropDownList CargarNacionalidades(DropDownList Lista)
        {
            Lista.DataSource = cn.ObtenerTabla("Nacionalidad", ConsultaSQLTablaLocalidades);
            Lista.DataTextField = "Nombre_NAC";
            Lista.DataValueField = "Id_Nacionalidad_NAC";
            Lista.DataBind();
     
            return Lista;
        }

        public DropDownList CargarNacionalidadesReg(DropDownList Lista, string registro)
        {
            Lista.DataSource = cn.ObtenerTabla("Nacionalidad", ConsultaSQLTablaLocalidades + " ORDER BY CASE WHEN Id_Nacionalidad_NAC = '" + registro + "' THEN 0 ELSE 1 END; ");
           Lista.DataTextField = "Nombre_NAC";
            Lista.DataValueField = "Id_Nacionalidad_NAC";
            Lista.DataBind();

            return Lista;
        }
    }
}
