using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Windows;
using Entidades;


namespace Dao
{
    public class DaoMedYAdm
    {
      
        ConexionBD cn = new ConexionBD();

        public int ActualizarAdmYMed(Administradores_Y_Medicos med)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosAdmYMed(ref comando, med);
            int filasInsertadas = cn.EjecutarProcedimientoAlmacenado(comando, "spActualizarMedicoYAdministrador");
            if (filasInsertadas == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        private void ArmarParametrosAdmYMed(ref SqlCommand Comando, Administradores_Y_Medicos med)
        {
            SqlParameter sqlParametros = new SqlParameter();
            Comando.Parameters.Clear();
            sqlParametros = Comando.Parameters.Add("@Usuario_AYM", SqlDbType.VarChar);
            sqlParametros.Value = med.getUsuario();
            sqlParametros = Comando.Parameters.Add("@Contraseña_AYM", SqlDbType.VarChar);
            sqlParametros.Value = med.getContraseña();
        }

        private void ArmarParametrosAgregarAdmsyMeds(ref SqlCommand Comando, Administradores_Y_Medicos aym)
        {
            SqlParameter sqlParametros = new SqlParameter();
            sqlParametros = Comando.Parameters.Add("@Usuario", SqlDbType.VarChar, 10);
            sqlParametros.Value = aym.getUsuario();
            sqlParametros = Comando.Parameters.Add("@Contrasenia", SqlDbType.VarChar, 10);
            sqlParametros.Value = aym.getContraseña();
            sqlParametros = Comando.Parameters.Add("@Tipo_Usuario", SqlDbType.VarChar, 15);
            sqlParametros.Value = aym.getTipo();
        }

        public bool agregarUsuario(Administradores_Y_Medicos aym)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosAgregarAdmsyMeds(ref comando, aym);

            int filasInsertadas = cn.EjecutarProcedimientoAlmacenado(comando, "spAgregarUsuario");

            if (filasInsertadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Devuelve la existencia de un nombre de usuario
        public bool verificarUsuario(string usuario)
        {
            string consultaSQL = ("SELECT * FROM Administradores_y_Medicos WHERE Usuario_AYM = '" + usuario + "'");
            return cn.existe(consultaSQL);
        }

  
        public bool modUsuario(string usuarioNuevo, string legajo)
        {
            string consulta = "UPDATE Administradores_y_Medicos SET Usuario_AYM = @UsuarioNuevo WHERE Legajo_AYM = @Legajo";

            using (SqlConnection conn = cn.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioNuevo", usuarioNuevo);
                    cmd.Parameters.AddWithValue("@Legajo", legajo);

                    //conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0; // Devuelve true si se actualizó al menos un registro
                }
            }
        }



    }
}
