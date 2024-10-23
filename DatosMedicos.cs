using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Entidades;

namespace Dao
{
  public  class DatosMedicos
    {
        ConexionBD cn = new ConexionBD();

        public DatosMedicos() { }
        public bool ActualizarMedicos(Medicos med)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMed(ref comando, med);
            
            int filasAfectadas = cn.EjecutarProcedimientoAlmacenado(comando, "spActualizarMedico");
           
            return filasAfectadas >= 1;
        }
        private void ArmarParametrosMed(ref SqlCommand Comand, Medicos m)
        {
            // Limpiar los parámetros existentes para evitar duplicados
            Comand.Parameters.Clear();

            // Agregar parámetros con los getters de la clase Medicos
            SqlParameter sqlParametros;

            sqlParametros = new SqlParameter("@Legajo_MED", SqlDbType.VarChar, 10);
            sqlParametros.Value = m.getLegajo_MED();
            Comand.Parameters.Add(sqlParametros);

            sqlParametros = new SqlParameter("@Dni_MED", SqlDbType.VarChar, 10);
            sqlParametros.Value = m.getDni_MED();
            Comand.Parameters.Add(sqlParametros);

            sqlParametros = new SqlParameter("@Nombre_MED", SqlDbType.VarChar, 20);
            sqlParametros.Value = m.getNombre_MED();
            Comand.Parameters.Add(sqlParametros);

            sqlParametros = new SqlParameter("@Apellido_MED", SqlDbType.VarChar, 20);
            sqlParametros.Value = m.getApellido_MED();
            Comand.Parameters.Add(sqlParametros);

            sqlParametros = new SqlParameter("@Id_Sexo_MED", SqlDbType.Char, 1);
            sqlParametros.Value = m.getId_Sexo_MED();
            Comand.Parameters.Add(sqlParametros);

            sqlParametros = new SqlParameter("@Id_Nacionalidad_MED", SqlDbType.VarChar, 4);
            sqlParametros.Value = m.getId_Nacionalidad_MED();
            Comand.Parameters.Add(sqlParametros);

            sqlParametros = new SqlParameter("@Fecha_Nacimiento_MED", SqlDbType.Date);
            sqlParametros.Value = m.getFecha_Nacimiento_MED();
            Comand.Parameters.Add(sqlParametros);

            sqlParametros = new SqlParameter("@Direccion_MED", SqlDbType.VarChar, 30);
            sqlParametros.Value = m.getDireccion_MED();
            Comand.Parameters.Add(sqlParametros);

            sqlParametros = new SqlParameter("@Cod_Localidad_MED", SqlDbType.VarChar, 4);
            sqlParametros.Value = m.getCod_Localidad_MED();
            Comand.Parameters.Add(sqlParametros);

            sqlParametros = new SqlParameter("@Cod_Provincia_MED", SqlDbType.VarChar, 4);
            sqlParametros.Value = m.getCod_Provincia_MED();
            Comand.Parameters.Add(sqlParametros);

            sqlParametros = new SqlParameter("@Correo_Electronico_MED", SqlDbType.VarChar, 50);
            sqlParametros.Value = m.getCorreo_Electronico_MED();
            Comand.Parameters.Add(sqlParametros);

            sqlParametros = new SqlParameter("@Telefono_MED", SqlDbType.VarChar, 15);
            sqlParametros.Value = m.getTelefono_MED();
            Comand.Parameters.Add(sqlParametros);

            sqlParametros = new SqlParameter("@Id_Especialidad_MED", SqlDbType.VarChar, 4);
            sqlParametros.Value = m.getId_Especialidad_MED();
            Comand.Parameters.Add(sqlParametros);

            sqlParametros = new SqlParameter("@Usuario_MED", SqlDbType.VarChar, 10);
            sqlParametros.Value = m.getUsuario_MED();
            Comand.Parameters.Add(sqlParametros);

            sqlParametros = new SqlParameter("@Estado_MED", SqlDbType.Bit);
            sqlParametros.Value = m.getEstado_MED();
            Comand.Parameters.Add(sqlParametros);

        }


        public DataTable TablaMedicos()
        {
            DataTable dt = cn.ObtenerTabla("Medicos", "SELECT Legajo_MED, Dni_MED , Nombre_MED, Apellido_MED , Id_Sexo_MED , Id_Nacionalidad_MED , Fecha_Nacimiento_MED , Direccion_MED , Cod_Localidad_MED, Cod_Provincia_MED , Correo_Electronico_MED , Telefono_MED , Id_Especialidad_MED , Usuario_MED , Estado_MED  FROM Medicos");
            return dt;
        }


    }
}
