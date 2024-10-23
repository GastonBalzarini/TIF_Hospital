using System.Text;
using System.Threading.Tasks;
using Dao;
using System.Data;
using Entidades;
using System.Web.UI.WebControls;

namespace Negocio
{
    public class NegocioEspecialidad
    {
        DaoEspecialidades DE = new DaoEspecialidades();

        public DropDownList ObtenerTablaEspecialidad(DropDownList Lista)
        {
            return DE.CargarEspecialidades(Lista);
        }

        public DropDownList ObtenerTablaEspReg(DropDownList Lista, string reg)
        {
            return DE.CargarEspecialidadessReg(Lista, reg);
        }
    }
}
