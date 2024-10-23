using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Dao
{
    public class ConexionBD
    {
        // Cadena de conexión a la base de datos
        private readonly string rutaBD = "Data Source=localhost\\sqlexpress;Initial Catalog=TPINT_GRUPO_14_PR3;Integrated Security=True";

        // Devuelve la conexión con la base de datos
        public SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBD);//nueva instancia de la clase SqlConnection, que se utiliza para establecer una conexión con una base de datos SQL Server.
            try
            {
                cn.Open(); // Intenta abrir la conexión
                return cn; // Retorna la conexión abierta
            }
            catch (Exception )
            {
                return null; // En caso de error, retorna null
            }
        }

        // Verifica la existencia de un registro basado en la consulta proporcionada
        public bool existe(string consulta)
        {
            bool estado = false;
            SqlConnection conexion = ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand(consulta, conexion); // Prepara el comando
                SqlDataReader datos = cmd.ExecuteReader(); // Ejecuta la consulta
             
                estado = datos.Read(); // Lee el resultado
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar existencia: {ex.Message}"); // Muestra un mensaje de error
            }
            finally
            {
                conexion.Close(); // Cierra la conexión
            }
            return estado; // Retorna el estado de existencia
        }

        // Ejecuta una consulta y devuelve la cantidad de filas afectadas
        public int EjecutarConsulta(string consulta)
        {
            int filasAfectadas = 0;
            SqlConnection conexion = ObtenerConexion();
            try
            {
                SqlCommand comando = new SqlCommand(consulta, conexion); // Prepara el comando
                filasAfectadas = comando.ExecuteNonQuery(); // Ejecuta la consulta
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar consulta: {ex.Message}"); // Muestra un mensaje de error
            }
            finally
            {
                conexion.Close(); // Cierra la conexión
            }
            return filasAfectadas; // Retorna la cantidad de filas afectadas
        }

        // Devuelve una tabla llena con los resultados de la consulta
        public DataTable ObtenerTabla(string nombre, string consulta)

        {
          
            DataSet ds = new DataSet(); // Crea un DataSet para almacenar la tabla
            try
            {
                SqlConnection conexion = ObtenerConexion(); // Obtiene la conexión
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion); // Prepara el adaptador
                adaptador.Fill(ds, nombre); // Llena el DataSet con la consulta

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener tabla: {ex.Message}"); // Muestra un mensaje de error
            }
            return ds.Tables[nombre]; // Retorna la tabla solicitada
        }

        // Devuelve el valor máximo de una columna basado en la consulta proporcionada
        public int ObtenerMaximo(string consulta)
        {
            int maximo = 0;
            SqlConnection conexion = ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand(consulta, conexion); // Prepara el comando
                SqlDataReader datos = cmd.ExecuteReader(); // Ejecuta la consulta
                if (datos.Read())
                {
                    maximo = Convert.ToInt32(datos[0]); // Lee el valor máximo
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener máximo: {ex.Message}"); // Muestra un mensaje de error
            }
            finally
            {
                conexion.Close(); // Cierra la conexión
            }
            return maximo; // Retorna el valor máximo
        }

        // Ejecuta un procedimiento almacenado y devuelve la cantidad de filas afectadas
        public int EjecutarProcedimientoAlmacenado(SqlCommand comando, string nombreSP)
        {
            int filasAfectadas = 0;
            SqlConnection conexion = null;
            try
            {
                conexion = ObtenerConexion(); // Obtiene la conexión
                if (conexion == null)
                {
                    throw new Exception("No se pudo obtener la conexión."); // Lanza excepción si la conexión es nula
                }

                comando.Connection = conexion; // Asigna la conexión al comando
                comando.CommandType = CommandType.StoredProcedure; // Establece el tipo de comando
                comando.CommandText = nombreSP; // Establece el nombre del procedimiento
                filasAfectadas = comando.ExecuteNonQuery(); // Ejecuta el procedimiento
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar procedimiento almacenado: {ex.Message}"); // Muestra un mensaje de error
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close(); // Cierra la conexión si está abierta
                }
            }
            return filasAfectadas; // Retorna la cantidad de filas afectadas
        }

        // Devuelve el resultado de una consulta que se establece al llamar a la función
        public int ObtenerResultado(string consulta)
        {
            int resultado = 0;
            SqlConnection conexion = ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand(consulta, conexion); // Prepara el comando
                SqlDataReader datos = cmd.ExecuteReader(); // Ejecuta la consulta
                if (datos.Read())
                {
                    resultado = Convert.ToInt32(datos[0]); // Lee el resultado
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener resultado: {ex.Message}"); // Muestra un mensaje de error
            }
            finally
            {
                conexion.Close(); // Cierra la conexión
            }
            return resultado; // Retorna el resultado de la consulta
        }
    }
}
