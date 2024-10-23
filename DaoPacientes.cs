using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Dao
{
    public class DaoPacientes
    {
        //Se declara una consulta general
        string ConsultaSQLTablaPacientes = "SELECT Dni_PAC, Nombre_PAC, Apellido_PAC, Sexo.Nombre_S AS Sexo,Id_Sexo_PAC, FORMAT(Fecha_Nacimiento_PAC, 'dd/MM/yyyy') AS Fecha_Nacimiento_PAC,Direccion_PAC, Nacionalidad.Nombre_NAC AS Nacionalidad,Id_Nacionalidad_PAC,Localidades.Nombre_LO AS Localidad,Cod_Localidad_PAC,Provincias.Nombre_PROV AS Provincia,Cod_Provincia_PAC,Correo_Electronico_PAC, Telefono_PAC FROM Pacientes INNER JOIN Sexo ON Pacientes.Id_Sexo_PAC= Sexo.Id_Sexo_S INNER JOIN Nacionalidad ON Pacientes.Id_Nacionalidad_PAC = Nacionalidad.Id_Nacionalidad_NAC INNER JOIN Provincias ON Pacientes.Cod_Provincia_PAC = Provincias.Id_Provincia_PROV INNER JOIN Localidades ON Pacientes.Cod_Localidad_PAC = Localidades.Id_Localidades_LO WHERE Pacientes.Estado_PAC = 1";
        
        //Se declara un objeto ConexionBD llamado cn
        ConexionBD cn = new ConexionBD();

        // Obtiene la tabla de pacientes llamando la funcion obtenerTabla de la clase ConexionBD
        public DataTable TablaPacientes()
        {
            DataTable dt = cn.ObtenerTabla("Pacientes", ConsultaSQLTablaPacientes);
            return dt;
        }

        // Devuelve una tabla con un paciente buscandolo con el DNI llamando la funcion obtenerTabla de la clase ConexionBD
        public DataTable BuscarPaciente(string IDDNI)
        {
            string consultaSQL = ConsultaSQLTablaPacientes + "and Dni_PAC ='" + IDDNI + "'";
            string nombreTabla = "Pacientes";
            return cn.ObtenerTabla(nombreTabla, consultaSQL);

        }

        // Devuelve una tabla con pacientes de tal sexo llamando la funcion obtenerTabla de la clase ConexionBD
        public DataTable BuscarPacxSexo(string sexoSeleccionado)
        {
            string consultaSQL = ConsultaSQLTablaPacientes + " and Id_Sexo_PAC ='" + sexoSeleccionado + "'";
            string nombreTabla = "Pacientes";
            return cn.ObtenerTabla(nombreTabla, consultaSQL);
        }

        //Devuelve una tabla con los pacientes que pertenecen a tal localidad llamando la funcion obtenerTabla de la clase ConexionBD
        public DataTable BuscarPacxLocalidad(string provinciaseleccionada)
        {
            string consultaSQL = ConsultaSQLTablaPacientes + " and Cod_Localidad_PAC ='" + provinciaseleccionada + "'";
            string nombreTabla = "Pacientes";
            return cn.ObtenerTabla(nombreTabla, consultaSQL);
        }

        //Realiza la baja logica de un paciente, volviendo su estado en 0 llamando la funcion EjecutarConsulta de la clase ConexionBD
        public void BajaLogicaPaciente(string DNI)
        {
            string consultaSQL = "Update Pacientes Set Estado_PAC = 0 where Dni_PAC ='"+DNI+"'";
            cn.EjecutarConsulta(consultaSQL);
        }

        //Realiza la alta logica de un paciente, volviendo su estado en 1 llamando la funcion EjecutarConsulta de la clase ConexionBD
        public void altaLogicaPaciente(string DNI)
        {
            string consultaSQL = "Update Pacientes Set Estado_PAC = 1 where Dni_PAC ='" + DNI + "'";
            cn.EjecutarConsulta(consultaSQL);
        }

        //Se declara los parametros que necesita el procedimiento almacenado
        private void ArmarParametrosPacientes(ref SqlCommand Comando, Pacientes pac)
        {
            SqlParameter sqlParametros = new SqlParameter();
            sqlParametros = Comando.Parameters.Add("@Dni_PAC", SqlDbType.VarChar, 10);
            sqlParametros.Value = pac.getDNIPaci();
            sqlParametros = Comando.Parameters.Add("@Nombre_PAC", SqlDbType.VarChar, 20);
            sqlParametros.Value = pac.getNombrePaci();
            sqlParametros = Comando.Parameters.Add("@Apellido_PAC", SqlDbType.VarChar, 20);
            sqlParametros.Value = pac.getApellidoPaci();
            sqlParametros = Comando.Parameters.Add("@Id_Sexo_PAC", SqlDbType.Char, 1);
            sqlParametros.Value = pac.getIDSexoPaci();
            sqlParametros = Comando.Parameters.Add("@Id_Nacionalidad_PAC", SqlDbType.VarChar, 4);
            sqlParametros.Value = pac.getIDNacPaci();
            sqlParametros = Comando.Parameters.Add("@Fecha_Nacimiento_PAC", SqlDbType.Date);
            sqlParametros.Value = pac.getFechaCPaci();
            sqlParametros = Comando.Parameters.Add("@Direccion_PAC", SqlDbType.VarChar, 30);
            sqlParametros.Value = pac.getDireccionPaci();
            sqlParametros = Comando.Parameters.Add("@Cod_Localidad_PAC", SqlDbType.VarChar, 4);
            sqlParametros.Value = pac.getCodLocPaci();
            sqlParametros = Comando.Parameters.Add("@Cod_Provincia_PAC", SqlDbType.VarChar, 4);
            sqlParametros.Value = pac.getCodProvPaci();
            sqlParametros = Comando.Parameters.Add("@Correo_Electronico_PAC", SqlDbType.VarChar, 50);
            sqlParametros.Value = pac.getCorreoElectPaci();
            sqlParametros = Comando.Parameters.Add("@Telefono_PAC", SqlDbType.VarChar, 15);
            sqlParametros.Value = pac.getTelefonoPaci();
            sqlParametros = Comando.Parameters.Add("@Estado_PAC", SqlDbType.Bit);
            sqlParametros.Value = pac.getEstadoPaci();
        }

        //Ejecuta el procedimiento almacenado llamando la funcion EjecutarProcedimientoAlmacenado de la clase ConexionBD,
        //obteniene los parametros previamente declarados y devuelve el estado de ejecucion
        public int agregarPaciente(Pacientes pac)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosPacientes(ref comando, pac);
            return cn.EjecutarProcedimientoAlmacenado(comando, "spAgregarPaciente");
        }

        //Se declara los parametros que necesita el procedimiento almacenado
        private void ArmarParametrosBajaPac(ref SqlCommand comando, Pacientes p)
        {
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Dni",p.getDNIPaci());
            comando.Parameters.AddWithValue("@Nombre",p.getNombrePaci());
            comando.Parameters.AddWithValue("@Apellido",p.getApellidoPaci());
            comando.Parameters.AddWithValue("@Id_Sexo",p.getIDSexoPaci());
            comando.Parameters.AddWithValue("@Id_Nacionalidad",p.getIDNacPaci());
            comando.Parameters.AddWithValue("@Direccion",p.getDireccionPaci());
            comando.Parameters.AddWithValue("@Cod_Localidad",p.getCodLocPaci());
            comando.Parameters.AddWithValue("@Cod_Provincia",p.getCodProvPaci());
            comando.Parameters.AddWithValue("@Correo_Electronico",p.getCorreoElectPaci());
            comando.Parameters.AddWithValue("@Telefono",p.getTelefonoPaci());
        }

        //Ejecuta el procedimiento almacenado llamando la funcion EjecutarProcedimientoAlmacenado de la clase ConexionBD,
        //obteniene los parametros previamente declarados y devuelve el estado de ejecucion
        public bool ActualizarPaciente(Pacientes p)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosBajaPac(ref comando, p);
            int filasInsertadas = cn.EjecutarProcedimientoAlmacenado(comando, "spActualizarPaciente");
            if (filasInsertadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Devuelve un DropDownList cargado con los pacientes es estado 1 llamando a la funcion ObtenerTabla de la clase ConexionBD
        public DropDownList DDLPacientes(DropDownList Lista)
        {
            string consultaSQL = $"SELECT Dni_PAC, Nombre_PAC + ' ' + Apellido_PAC+' '+Dni_PAC  AS NombreCompletoDni  FROM Pacientes WHERE Estado_PAC = 1 ORDER BY NombreCompletoDni ASC ";

            Lista.DataSource = cn.ObtenerTabla("Pacientes", consultaSQL);
            Lista.DataTextField = "NombreCompletoDni";
            Lista.DataValueField = "Dni_PAC";
            Lista.DataBind();
 
            return Lista;
        }

        //Devuelve la existencia de un paciente llamando la funcion existe de la clase ConexionBD
        public bool existeDNI(string dni)
        {
            string consultaSQL = ("SELECT * FROM Pacientes WHERE Dni_PAC = '" + dni + "'");
            return cn.existe(consultaSQL);
        }

        //Devuelve el estado de un paciente llamando la funcion existe de la clase ConexionBD
        public bool existeRegElim(string dni)
        {
            string consultaSQL = ("SELECT * FROM Pacientes WHERE Dni_PAC = '" + dni + "' and Estado_PAC = 0");
            return cn.existe(consultaSQL);
        }

    }
}
