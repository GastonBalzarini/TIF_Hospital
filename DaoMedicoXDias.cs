using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using Entidades;

namespace Dao
{   
    public class DaoMedicoXDias
    {
        ConexionBD cn = new ConexionBD();
        Medicos_X_Dias MXD = new Medicos_X_Dias();

        /*******************************************************************************************************/
        //Devuelve un RadioButtonList que contiene los dias y horarios de tal medico
        public RadioButtonList ObtenerRadioBList(RadioButtonList lista,string idMedico)
        {
            //esta consulta busca obtener los días y horas disponibles para un médico específico que aún no tienen un turno asignado.
            string consultaSQL = $@"SELECT  MXD.Legajo_MXD,MXD.Dia_MXD, CONVERT(VARCHAR(8), MXD.Hora_Atencion_MXD, 108) AS Hora,
                                MXD.Dia_MXD + ' ' + CONVERT(VARCHAR(8), MXD.Hora_Atencion_MXD, 108) AS DiaYHora,

                              MXD.Legajo_MXD + ',' + MXD.Dia_MXD + ',' + CONVERT(VARCHAR(20), MXD.Hora_Atencion_MXD, 120) AS ValueField   

                                FROM     Medicos_X_Dias AS MXD LEFT JOIN     Turnos AS T ON MXD.Legajo_MXD = T.Legajo_TUR AND MXD.Dia_MXD = T.Dia_TUR AND MXD.Hora_Atencion_MXD = T.Hora_TUR
                                WHERE    MXD.Legajo_MXD = '{idMedico}'     AND T.Legajo_TUR IS NULL ";



            lista.DataSource = cn.ObtenerTabla("Medicos_X_Dias",consultaSQL);
            lista.DataTextField = "DiaYHora";
            lista.DataValueField = "ValueField"; // Valor oculto en la list
            lista.DataBind();

            return lista;
        }
        /***************************************************************************************************************/



        //Se declara los parametros que necesita el procedimiento almacenado
        private void ArmarParametrosMedicosXDias(ref SqlCommand Comando, Medicos_X_Dias obj)
        {
            SqlParameter sqlParametros = new SqlParameter();
            sqlParametros = Comando.Parameters.Add("@Legajo_MXD", SqlDbType.VarChar, 10);
            sqlParametros.Value = obj.Legajo1;
            sqlParametros = Comando.Parameters.Add("@Dia_MXD", SqlDbType.VarChar, 10);
            sqlParametros.Value = obj.Dia1;
            sqlParametros = Comando.Parameters.Add("@Hora_Atencion_MXD", SqlDbType.DateTime);
            sqlParametros.Value = obj.Hora;
        }

        //Ejecuta el procedimiento almacenado llamando la funcion EjecutarProcedimientoAlmacenado de la clase ConexionBD,
        //obteniene los parametros previamente declarados y devuelve el estado de ejecucion
        public int AgregarAtencion(Medicos_X_Dias obj)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMedicosXDias(ref comando, obj);
            return cn.EjecutarProcedimientoAlmacenado(comando, "spInsertarMedicoDia");
        }

    }
}
