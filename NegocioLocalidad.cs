using System.Text;
using System.Threading.Tasks;
using Dao;
using System.Data;
using Entidades;
using System.Web.UI.WebControls;

namespace Negocio
{
    public class NegocioLocalidad
    {
        DaoLocalidades DL = new DaoLocalidades();

        public DropDownList ObtenerTablaLocalidad(DropDownList Lista)
        {
            return DL.CargarLocalidades(Lista);
        }

        public DropDownList ObtenerTablaLocReg(DropDownList Lista,string reg)
        {
            return DL.CargarLocalidadesReg(Lista,reg);
        }
    }

}
