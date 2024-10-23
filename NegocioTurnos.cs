using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Dao;
using System.Data;

namespace Negocio
{
    public class NegocioTurnos
    {
        // Instancia de la clase DaoTurnos para manejar operaciones relacionadas con turnos
        DaoTurnos DT = new DaoTurnos();

        /********************************************************************************************/
        // Método para insertar un turno en la base de datos
        public int InsertarTurno(string legajo, string dia, DateTime hora, string dniPaciente)
        {
            return DT.Insertar(legajo, dia, hora, dniPaciente); // Llama al método Insertar del DAO
        }
        /********************************************************************************************/

        // Método para obtener un informe de paciente basado en su DNI
        public DataTable informePac(string DNI)
        {
            return DT.informePaciente(DNI); // Llama al método informePaciente del DAO
        }

        // Método para obtener un informe de pacientes según su sexo
        public DataTable informeSe(string sexo)
        {
            return DT.informeSexo(sexo); // Llama al método informeSexo del DAO
        }

        public DataTable ObtenerTablaTurnos()
        {
            return DT.TablaTurnos(); // Llama al método TablaTurnos del DAOturnos
        }

        // Método para obtener una tabla de turnos según el legajo del médico
        public DataTable ObtenerTablaTurnos(string legajo)
        {
            return DT.TablaTurnos(legajo); // Llama al método TablaTurnos del DAO
        }

        // Método para obtener el legajo de un usuario
        public string obtenerLegajo(string usuario)
        {
            return DT.ObtenerLegajoPorUsuario(usuario); // Llama al método ObtenerLegajoPorUsuario del DAO
        }

        // Método para cambiar la asistencia de un paciente a un turno
        public void cambiarAsistencia(string legajo, string dia, string hora, string dni)
        {
            DT.cambiarAsistencias(legajo, dia, hora, dni); // Llama al método cambiarAsistencias del DAO
        }

        // Método para agregar una observación a un turno
        public void agregarObservacion(string legajo, string dia, string hora, string dni, string observacion)
        {
            DT.agregarObse(legajo, dia, hora, dni, observacion); // Llama al método agregarObse del DAO
        }

        // Método para buscar pacientes por DNI
        public DataTable buscarPorDni(string dni, string legajo)
        {
            return DT.buscarPorDNI(dni, legajo); // Llama al método buscarPorDNI del DAO
        }

        // Método para buscar pacientes por sexo
        public DataTable buscarPorSexo(string sexo, string legajo)
        {
            return DT.buscarPorSe(sexo, legajo); // Llama al método buscarPorSe del DAO
        }
    }
}
