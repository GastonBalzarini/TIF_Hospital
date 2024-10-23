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
     public class DaoSexo
    {
        string ConsultaSQLTablaLocalidades = "SELECT * FROM Sexo";
        ConexionBD cn = new ConexionBD();

        public DropDownList CargarSexo(DropDownList Lista)
        {
            Lista.DataSource = cn.ObtenerTabla("Sexo", ConsultaSQLTablaLocalidades);
            Lista.DataTextField = "Nombre_S";
            Lista.DataValueField = "Id_Sexo_S";
            Lista.DataBind();
            
            return Lista;
        }

        public DropDownList CargarSexoReg(DropDownList Lista, string registro)
        {
            Lista.DataSource = cn.ObtenerTabla("Sexo", ConsultaSQLTablaLocalidades + " ORDER BY CASE WHEN Id_Sexo_S = '" + registro + "' THEN 0 ELSE 1 END; ");
            Lista.DataTextField = "Nombre_S";
            Lista.DataValueField = "Id_Sexo_S";
            Lista.DataBind();

            return Lista;
        }
    }
}
