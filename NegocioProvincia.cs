using System.Text;
using System.Threading.Tasks;
using Dao;
using System.Data;
using Entidades;
using System.Web.UI.WebControls;

namespace Negocio
{
    public class NegocioProvincia
    {
        DaoProvincias DP = new DaoProvincias();

        public DropDownList ObtenerTablaProvincias(DropDownList Lista)
        {
            return DP.CargarProvincias(Lista);
        }

        public DropDownList ObtenerTablaProvReg(DropDownList Lista, string reg)
        {
            return DP.CargarProvReg(Lista, reg);
        }
    }
}
