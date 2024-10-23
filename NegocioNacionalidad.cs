using System.Text;
using System.Threading.Tasks;
using Dao;
using System.Data;
using Entidades;
using System.Web.UI.WebControls;

namespace Negocio
{
    public class NegocioNacionalidad
    {
        DaoNacionalidad DN = new DaoNacionalidad();

        public DropDownList ObtenerTablaNacionalidad(DropDownList Lista)
        {
            return DN.CargarNacionalidades(Lista);
        }

        public DropDownList ObtenerTablaNacReg(DropDownList Lista, string reg)
        {
            return DN.CargarNacionalidadesReg(Lista, reg);
        }
    }
}
