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
    public class DaoProvincias
    {
        string ConsultaSQLTablaLocalidades = "SELECT * FROM Provincias";
        ConexionBD cn = new ConexionBD();

        public DropDownList CargarProvincias(DropDownList Lista)
        {
            Lista.DataSource = cn.ObtenerTabla("Provincias", ConsultaSQLTablaLocalidades);
            Lista.DataTextField = "Nombre_PROV";
            Lista.DataValueField = "Id_Provincia_PROV";
            Lista.DataBind();
            
            return Lista;
        }

        public DropDownList CargarProvReg(DropDownList Lista, string registro)
        {
            Lista.DataSource = cn.ObtenerTabla("Provincias", ConsultaSQLTablaLocalidades + " ORDER BY CASE WHEN Id_Provincia_PROV = " + registro + " THEN 0 ELSE 1 END; ");
            Lista.DataTextField = "Nombre_PROV";
            Lista.DataValueField = "Id_Provincia_PROV";
            Lista.DataBind();

            return Lista;
        }
    }
}
