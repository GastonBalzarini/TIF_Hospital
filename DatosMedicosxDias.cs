using Entidades; //AGREGO CLASE ENTIDADES

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
   public class DatosMedicosxDias
    {
        ConexionBD cn = new ConexionBD();

        public int agregarMedicoxDias(Medicos_X_Dias MedxD)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMedicosxDias(ref comando, MedxD);
            return cn.EjecutarProcedimientoAlmacenado(comando, "sp_AgregarMedicosXDias");

        }

        private void ArmarParametrosMedicosxDias(ref SqlCommand Comando, Medicos_X_Dias MedxD)
        {
            SqlParameter sqlParametros = new SqlParameter();

            sqlParametros = Comando.Parameters.Add("@Legajo", SqlDbType.VarChar);
            sqlParametros.Value = MedxD.Legajo1;
            sqlParametros = Comando.Parameters.Add("@Dia", SqlDbType.VarChar);
            sqlParametros.Value = MedxD.Dia1;
            sqlParametros = Comando.Parameters.Add("@Hora", SqlDbType.DateTime);
            sqlParametros.Value = MedxD.Hora;
           
        }


    }
}
