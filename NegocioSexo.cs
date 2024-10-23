using System.Text;
using System.Threading.Tasks;
using Dao;
using System.Data;
using Entidades;
using System.Web.UI.WebControls;
namespace Negocio
{
    public class NegocioSexo
    {
        DaoSexo DS = new DaoSexo();

        public DropDownList ObtenerTablaSexo(DropDownList Lista)
        {
            return DS.CargarSexo(Lista);
        }

        public DropDownList ObtenerTablaSeReg(DropDownList Lista, string reg)
        {
            return DS.CargarSexoReg(Lista, reg);
        }
    }
}
