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
    
    public class DaoTurnos
    {
        // Instancia de la clase de conexión a la base de datos
        ConexionBD cn = new ConexionBD();

        /***************************************************************************************************************/
        // Método para insertar un nuevo turno
        public int Insertar(string legajo, string dia, DateTime hora, string dniPaciente)
        {
            // Consulta SQL para insertar un nuevo turno
            string consultaSQL = @"INSERT INTO Turnos (Legajo_TUR, Dia_TUR, Hora_TUR, Dni_Paciente_TUR, Asistencia_TUR) 
                                   VALUES (@Legajo, @Dia, @Hora, @DniPaciente, 0)";

            // Uso de SqlCommand para ejecutar la consulta
            using (SqlCommand cmd = new SqlCommand(consultaSQL, cn.ObtenerConexion()))
            {
                // Agregar parámetros a la consulta
                cmd.Parameters.AddWithValue("@Legajo", legajo);
                cmd.Parameters.AddWithValue("@Dia", dia);
                cmd.Parameters.AddWithValue("@Hora", hora);
                cmd.Parameters.AddWithValue("@DniPaciente", dniPaciente);

                // Ejecutar la consulta y devolver el número de filas insertadas
                int FilasInsertadas = cmd.ExecuteNonQuery();
                return FilasInsertadas;
            }
        }
        /*********************************************************************************************************************/


        // Método para generar un informe de asistencias para un paciente específico
        public DataTable informePaciente(string DNI)
        {
            // Consulta SQL para contar asistencias e inasistencias
            string consultaSQL = "SELECT COUNT(CASE WHEN Asistencia_TUR = 0 THEN 1 ELSE NULL END) AS Inasistencias, " +
                                 "COUNT(CASE WHEN Asistencia_TUR = 1 THEN 1 ELSE NULL END) AS Asistencias, " +
                                 "(Nombre_PAC+' '+Apellido_PAC) as Nombre, Dni_Paciente_TUR as DNI " +
                                 "FROM Turnos INNER JOIN Pacientes ON Dni_Paciente_TUR = Dni_PAC " +
                                 "WHERE Dni_Paciente_TUR = " + DNI + " GROUP BY Dni_Paciente_TUR, Nombre_PAC, Apellido_PAC";

            // Obtener el resultado en un DataTable
            DataTable DT = cn.ObtenerTabla("Turnos", consultaSQL);
            return DT;
        }

        // Método para generar un informe de asistencias por sexo
        public DataTable informeSexo(string sexo)
        {
            // Consulta SQL para contar asistencias agrupadas por sexo
            string consultaSQL = "SELECT COUNT(CASE WHEN Asistencia_TUR = 0 THEN 1 ELSE NULL END) AS Inasistencias, " +
                                 "COUNT(CASE WHEN Asistencia_TUR = 1 THEN 1 ELSE NULL END) AS Asistencias, " +
                                 "Id_Sexo_PAC, Nombre_S as Sexo " +
                                 "FROM Turnos INNER JOIN Pacientes ON Turnos.Dni_Paciente_TUR = Pacientes.Dni_PAC " +
                                 "INNER JOIN Sexo ON Id_Sexo_PAC = Id_Sexo_S " +
                                 "WHERE Id_Sexo_PAC = '" + sexo + "' GROUP BY Id_Sexo_PAC, Nombre_S";

            // Obtener el resultado en un DataTable
            DataTable DT = cn.ObtenerTabla("Turnos", consultaSQL);
            return DT;
        }


        public DataTable TablaTurnos()
        {
            // Consulta SQL para obtener los turnos 
            string consultaSQL = @"
SELECT 
    T.[Legajo_TUR],
    T.[Dia_TUR],
    T.[Hora_TUR],
    T.[Dni_Paciente_TUR],
    T.[Observacion_TUR],
    T.[Asistencia_TUR],
    (M.[Nombre_MED] + ' ' + M.[Apellido_MED]) AS 'Nombre_Medico',
    E.[Nombre_ES],
    (P.[Nombre_PAC] + ' ' + P.[Apellido_PAC]) AS 'Nombre_Paciente'
FROM 
    Turnos T
INNER JOIN 
    Medicos M ON T.[Legajo_TUR] = M.[Legajo_MED]
INNER JOIN 
    Especialidades E ON M.[Id_Especialidad_MED] = E.[Id_Especialidad_ES]
INNER JOIN 
    Pacientes P ON T.[Dni_Paciente_TUR] = P.[Dni_PAC];
";

            // Obtener el resultado en un DataTable
            DataTable DT = cn.ObtenerTabla("Turnos", consultaSQL);
            return DT;
        }


        // Método para obtener todos los turnos de un médico específico
        public DataTable TablaTurnos(string legajo)
        {
            // Consulta SQL para obtener los turnos del médico
            string consultaSQL = "SELECT Dia_TUR, Hora_TUR, (Nombre_PAC+' '+Apellido_PAC) as Nombre, " +
                                 "Dni_Paciente_TUR, FORMAT(Fecha_Nacimiento_PAC, 'dd/MM/yyyy') AS Fecha_Nacimiento_PAC, " +
                                 "Observacion_TUR, Asistencia_TUR " +
                                 "FROM Turnos INNER JOIN Pacientes ON Dni_PAC = Dni_Paciente_TUR " +
                                 "WHERE Legajo_TUR = '" + legajo + "'";

            // Obtener el resultado en un DataTable
            DataTable DT = cn.ObtenerTabla("Turnos", consultaSQL);
            return DT;
        }

      
        // Método para alternar el estado de asistencia de un turno
        public int cambiarAsistencias(string legajo, string dia, string hora, string dniPaciente)
        {
            // Consulta SQL para alternar la asistencia
            string consultaSQL = "UPDATE Turnos SET Asistencia_TUR = CASE " +
                                 "WHEN Asistencia_TUR = 0 THEN 1 " +
                                 "WHEN Asistencia_TUR = 1 THEN 0 END " +
                                 "WHERE Dia_TUR = @Dia and Hora_TUR = @Hora and " +
                                 "Dni_Paciente_TUR = @DniPaciente and Legajo_TUR = @Legajo";

            // Uso de SqlCommand para ejecutar la consulta
            using (SqlCommand cmd = new SqlCommand(consultaSQL, cn.ObtenerConexion()))
            {
                // Agregar parámetros a la consulta
                cmd.Parameters.AddWithValue("@Legajo", legajo);
                cmd.Parameters.AddWithValue("@Dia", dia);
                cmd.Parameters.AddWithValue("@Hora", hora);
                cmd.Parameters.AddWithValue("@DniPaciente", dniPaciente);

                // Ejecutar la consulta y devolver el número de filas afectadas
                int FilasInsertadas = cmd.ExecuteNonQuery();
                return FilasInsertadas;
            }
        }

        // Método para agregar una observación a un turno
        public void agregarObse(string legajo, string dia, string hora, string dni, string observacion)
        {
            // Consulta SQL para actualizar la observación
            string consultaSQL = "UPDATE Turnos SET Observacion_TUR = '" + observacion + "' " +
                                 "WHERE Dia_TUR = '" + dia + "' and Hora_TUR = '" + hora +
                                 "' and Dni_Paciente_TUR = '" + dni + "' and Legajo_TUR = '" + legajo + "'";

            // Ejecutar la consulta
            cn.EjecutarConsulta(consultaSQL);
        }

        // Método para buscar turnos por DNI del paciente
        public DataTable buscarPorDNI(string dni, string legajo)
        {
            // Consulta SQL para obtener turnos de un paciente específico
            string consultaSQL = "SELECT Dia_TUR, Hora_TUR, (Nombre_PAC+' '+Apellido_PAC) as Nombre, " +
                                 "Dni_Paciente_TUR, FORMAT(Fecha_Nacimiento_PAC, 'dd/MM/yyyy') AS Fecha_Nacimiento_PAC, " +
                                 "Observacion_TUR, Asistencia_TUR " +
                                 "FROM Turnos INNER JOIN Pacientes ON Dni_PAC = Dni_Paciente_TUR " +
                                 "WHERE Legajo_TUR = '" + legajo + "' and Dni_Paciente_TUR = '" + dni + "'";
            // Obtener el resultado en un DataTable
            DataTable DT = cn.ObtenerTabla("Turnos", consultaSQL);
            return DT;
        }

        // Método para buscar turnos por sexo del paciente
        public DataTable buscarPorSe(string sexo, string legajo)
        {
            // Consulta SQL para obtener turnos filtrados por sexo
            string consultaSQL = "SELECT Dia_TUR, Hora_TUR, (Nombre_PAC+' '+Apellido_PAC) as Nombre, " +
                                 "Dni_Paciente_TUR, FORMAT(Fecha_Nacimiento_PAC, 'dd/MM/yyyy') AS Fecha_Nacimiento_PAC, " +
                                 "Observacion_TUR, Asistencia_TUR " +
                                 "FROM Turnos INNER JOIN Pacientes ON Dni_PAC = Dni_Paciente_TUR " +
                                 "WHERE Legajo_TUR = '" + legajo + "' and Id_Sexo_PAC = '" + sexo + "'";
            // Obtener el resultado en un DataTable
            DataTable DT = cn.ObtenerTabla("Turnos", consultaSQL);
            return DT;
        }

        // Método para obtener el legajo de un médico a partir de su nombre de usuario
        public string ObtenerLegajoPorUsuario(string usuario)
        {
            // Consulta SQL para buscar el legajo del médico
            string consultaSQL = $"SELECT Legajo_MED FROM Medicos WHERE Usuario_MED = '{usuario}'";

            string legajo = null;

            // Uso de SqlConnection para ejecutar la consulta
            using (SqlConnection conexion = cn.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(consultaSQL, conexion);

                try
                {
                    // Ejecutar la consulta y obtener el legajo
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        legajo = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores en caso de fallo en la consulta
                    MessageBox.Show($"Error al obtener legajo por usuario: {ex.Message}");
                }
            }

            return legajo; // Retornar el legajo encontrado o null
        }
    }
}
