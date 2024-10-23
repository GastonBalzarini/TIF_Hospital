using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Dao;
using System.Web.UI.WebControls;
using System.Windows;

namespace Negocio
{
   public class NegocioMedicoXDias
    {
        DaoMedicoXDias DMXD = new DaoMedicoXDias();

        public RadioButtonList ObtenerDias(RadioButtonList lista, string idMedico)
        {
            return DMXD.ObtenerRadioBList(lista,idMedico);
        }

        public int AgregarDiasAtencion(Medicos_X_Dias obj)
        {
            return DMXD.AgregarAtencion(obj);
        }
    }
}
