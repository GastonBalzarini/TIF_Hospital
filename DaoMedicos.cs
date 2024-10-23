using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Windows;
using Entidades;

namespace Dao
{
    public class DaoMedicos
    {
        //Se declara una consulta general
        private string ConsultaSQLTablaMedicos = "SELECT Legajo_MED, Dni_MED, Nombre_MED, Apellido_MED, Sexo.Nombre_S AS Sexo, Id_Sexo_MED, FORMAT(Fecha_Nacimiento_MED, 'dd/MM/yyyy') AS Fecha_Nacimiento_MED, Direccion_MED, Nacionalidad.Nombre_NAC AS Nacionalidad, Id_Nacionalidad_MED, Localidades.Nombre_LO AS Localidad, Cod_Localidad_MED, Provincias.Nombre_PROV AS Provincia, Cod_Provincia_MED, Correo_Electronico_MED, Telefono_MED, Especialidades.Nombre_ES AS Especialidad, Id_Especialidad_MED FROM Medicos INNER JOIN Sexo ON Medicos.Id_Sexo_MED = Sexo.Id_Sexo_S INNER JOIN Nacionalidad ON Medicos.Id_Nacionalidad_MED = Nacionalidad.Id_Nacionalidad_NAC INNER JOIN Provincias ON Medicos.Cod_Provincia_MED = Provincias.Id_Provincia_PROV INNER JOIN Localidades ON Medicos.Cod_Localidad_MED = Localidades.Id_Localidades_LO INNER JOIN Especialidades ON Medicos.Id_Especialidad_MED = Especialidades.Id_Especialidad_ES WHERE Medicos.Estado_MED = 1";

        //Se declara un objeto ConexionBD llamado cn
        ConexionBD cn = new ConexionBD();


       public int ModUsuario(string legajo,string usuarioNuevo)
        {
            string consulta= "update  Administradores_Y_Medicos Set Usuario_AYM = '" + usuarioNuevo + "'" + " where Legajo_AYM = '" + legajo + "'";
            MessageBox.Show(consulta);
           return cn.EjecutarConsulta(consulta);
        }

        public string BLegajo(string usuario)
        {
            string legajo = string.Empty;
            string consulta = $"SELECT Legajo_MED FROM Medicos WHERE Usuario_MED = '{usuario}'";
            MessageBox.Show(consulta);
            using (SqlConnection conn = cn.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                   
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        legajo = result.ToString();
                    }
                }
            }
            MessageBox.Show(legajo);
            return legajo;
        }

       
   

        /********************************************************************************************************/
        // Devuelve un DropDownList cargado con los medicos de tal especialidad en estado 1 llamando a la funcion ObtenerTabla de la clase ConexionBD
        public DropDownList CargarMedico(DropDownList Lista, string idespecialidad)
        {
            string consultaSQL = $"SELECT Legajo_MED, Nombre_MED + ' ' + Apellido_MED AS NombreCompleto  FROM Medicos WHERE Estado_MED = 1 AND Id_Especialidad_MED ='{idespecialidad}'";
     
            Lista.DataSource = cn.ObtenerTabla("Medicos", consultaSQL);
            Lista.DataTextField = "NombreCompleto";
            Lista.DataValueField = "Legajo_MED";
            Lista.DataBind();

            return Lista;
        }
        /*************************************************************************************************************/

   

        //Ejecuta el procedimiento almacenado llamando la funcion EjecutarProcedimientoAlmacenado de la clase ConexionBD,
        //obteniene los parametros previamente declarados y devuelve el estado de ejecucion
        public bool ActualizarMedico(Medicos med)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMed(ref comando, med);
            int filasInsertadas = cn.EjecutarProcedimientoAlmacenado(comando, "spActualizarMedico");
            if (filasInsertadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Devuelve la tabla Medicos llamando la funcion obtenerTabla de la clase ConexionBD
        public DataTable TablaMedicos()
        {
            DataTable dt = cn.ObtenerTabla("Medicos", ConsultaSQLTablaMedicos);
            return dt;
        }

        //Se declara los parametros que necesita el procedimiento almacenado
        private void ArmarParametrosMed(ref SqlCommand comando, Medicos m)
        {
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Legajo_MED", m.getLegajo_MED());
            comando.Parameters.AddWithValue("@Nombre_MED", m.getNombre_MED());
            comando.Parameters.AddWithValue("@Apellido_MED", m.getApellido_MED());
            comando.Parameters.AddWithValue("@Id_Sexo_MED", m.getId_Sexo_MED());
            comando.Parameters.AddWithValue("@Id_Nacionalidad_MED", m.getId_Nacionalidad_MED());
            comando.Parameters.AddWithValue("@Direccion_MED", m.getDireccion_MED());
            comando.Parameters.AddWithValue("@Cod_Localidad_MED", m.getCod_Localidad_MED());
            comando.Parameters.AddWithValue("@Cod_Provincia_MED", m.getCod_Provincia_MED());
            comando.Parameters.AddWithValue("@Correo_Electronico_MED", m.getCorreo_Electronico_MED());
            comando.Parameters.AddWithValue("@Telefono_MED", m.getTelefono_MED());
            comando.Parameters.AddWithValue("@Id_Especialidad_MED", m.getId_Especialidad_MED());
        }

        //Devuelve una tabla cargada con los medicos con contengan tal texto en su nombre llamando la funcion obtenerTabla de la clase ConexionBD
        public DataTable BuscarMedico(string texto)
        {
            string consultaSQL = ConsultaSQLTablaMedicos + "and Nombre_MED LIKE '%" + texto + "%' OR Apellido_MED LIKE '%" + texto + "%'";
            string nombreTabla = "Medicos";
            return cn.ObtenerTabla(nombreTabla, consultaSQL);
        }

        //Devuelve una tabla cargada con los medicos de tal sexo llamando la funcion obtenerTabla de la clase ConexionBD
        public DataTable BuscarMedxSexo(string sexoseleccionado)
        {
            string consultaSQL = ConsultaSQLTablaMedicos + " and Id_Sexo_MED ='" + sexoseleccionado + "'";
            string nombreTabla = "Medicos";
            return cn.ObtenerTabla(nombreTabla, consultaSQL);
        }

        //Devuelve una tabla cargada con los medicos de tal provincia llamando la funcion obtenerTabla de la clase ConexionBD
        public DataTable BuscarMedxProvincia(string provinciaseleccionada)
        {
            string consultaSQL = ConsultaSQLTablaMedicos + " and Cod_Provincia_MED ='" + provinciaseleccionada + "'";
            string nombreTabla = "Medicos";
            return cn.ObtenerTabla(nombreTabla, consultaSQL);
        }

        //Devuelve una tabla cargada con los medicos de tal especialidad llamando la funcion obtenerTabla de la clase ConexionBD
        public DataTable BuscarMedxEspecialidad(string EspecialidadSeleccionada)
        {
            string consultaSQL = ConsultaSQLTablaMedicos + " and Id_Especialidad_MED ='" + EspecialidadSeleccionada + "'";
            string nombreTabla = "Medicos";
            return cn.ObtenerTabla(nombreTabla, consultaSQL);
        }

        //Ejecuta el procedimiento almacenado llamando la funcion EjecutarProcedimientoAlmacenado de la clase ConexionBD,
        //obteniene los parametros previamente declarados y devuelve el estado de ejecucion
        public bool agregarMedico(Medicos med)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMedicos(ref comando, med);
            int filasInsertadas = cn.EjecutarProcedimientoAlmacenado(comando, "spAgregarMedico");
            if (filasInsertadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Se declara los parametros que necesita el procedimiento almacenado
        private void ArmarParametrosMedicos(ref SqlCommand Comando, Medicos med)
        {
            SqlParameter sqlParametros = new SqlParameter();
            sqlParametros = Comando.Parameters.Add("@Legajo_MED", SqlDbType.VarChar);
            sqlParametros.Value = med.getLegajo_MED();
            sqlParametros = Comando.Parameters.Add("@Dni_MED", SqlDbType.VarChar);
            sqlParametros.Value = med.getDni_MED();
            sqlParametros = Comando.Parameters.Add("@Nombre_MED", SqlDbType.VarChar);
            sqlParametros.Value = med.getNombre_MED();
            sqlParametros = Comando.Parameters.Add("@Apellido_MED", SqlDbType.VarChar);
            sqlParametros.Value = med.getApellido_MED();
            sqlParametros = Comando.Parameters.Add("@Id_Sexo_MED", SqlDbType.VarChar);
            sqlParametros.Value = med.getId_Sexo_MED();
            sqlParametros = Comando.Parameters.Add("@Id_Nacionalidad_MED", SqlDbType.VarChar);
            sqlParametros.Value = med.getId_Nacionalidad_MED();
            sqlParametros = Comando.Parameters.Add("@Fecha_Nacimiento_MED", SqlDbType.DateTime);
            sqlParametros.Value = med.getFecha_Nacimiento_MED();
            sqlParametros = Comando.Parameters.Add("@Direccion_MED", SqlDbType.VarChar);
            sqlParametros.Value = med.getDireccion_MED();
            sqlParametros = Comando.Parameters.Add("@Cod_Localidad_MED", SqlDbType.VarChar);
            sqlParametros.Value = med.getCod_Localidad_MED();
            sqlParametros = Comando.Parameters.Add("@Cod_Provincia_MED", SqlDbType.VarChar);
            sqlParametros.Value = med.getCod_Provincia_MED();
            sqlParametros = Comando.Parameters.Add("@Correo_Electronico_MED", SqlDbType.VarChar);
            sqlParametros.Value = med.getCorreo_Electronico_MED();
            sqlParametros = Comando.Parameters.Add("@Telefono_MED", SqlDbType.VarChar);
            sqlParametros.Value = med.getTelefono_MED();
            sqlParametros = Comando.Parameters.Add("@Id_Especialidad_MED", SqlDbType.VarChar);
            sqlParametros.Value = med.getId_Especialidad_MED();
            sqlParametros = Comando.Parameters.Add("@Usuario_MED", SqlDbType.VarChar);
            sqlParametros.Value = med.getUsuario_MED();
            sqlParametros = Comando.Parameters.Add("@Tipo_Usuario_MED", SqlDbType.VarChar);
            sqlParametros.Value = med.getTipo_Usuario_MED();
            sqlParametros = Comando.Parameters.Add("@Estado_MED", SqlDbType.Bit);
            sqlParametros.Value = med.getEstado_MED();
        }

        //Devuelve la existencia de un usuario llamando la funcion existe de la clase ConexionBD
        public bool existeUsuarioMED(string legajo)
        {
            string consultaSQL = ("SELECT * FROM Medicos WHERE Legajo_MED = '" + legajo + "'");

            MessageBox.Show(consultaSQL);
            return cn.existe(consultaSQL);
        }

        //Realiza la baja logica llamando la funcion EjecutarConsulta de la clase ConexionBD
        public void BajaLogicaMedico(string LEG)
        {
            string consultaSQL = "Update Medicos Set Estado_MED = 0 where Legajo_MED ='" + LEG + "'";
            cn.EjecutarConsulta(consultaSQL);
        }

        //Devuelve la existencia de un medico llamando la funcion existe de la clase ConexionBD
        public bool existeLegajoMED(string legajo)
        {
            string consultaSQL = ("SELECT * FROM Medicos WHERE Legajo_MED = '" + legajo + "'");
            return cn.existe(consultaSQL);
        }
    }
}
