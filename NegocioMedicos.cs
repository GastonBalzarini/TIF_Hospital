using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using Dao;
using Entidades;

namespace Negocio
{
    public  class NegocioMedicos
    {
        DaoMedicos dm = new DaoMedicos();

      public int ModificarUsuario(string legajo,string usuarioNuevo)
        {
            return dm.ModUsuario(legajo, usuarioNuevo);
        }

        public string BuscarLegajo(string usuario)
        {
            return dm.BLegajo(usuario);
        }
        public DataTable ObtenerTablaMedicos()
        {
            return dm.TablaMedicos();
        }
        public bool Actualizar(Medicos medico)
        {
          return  dm.ActualizarMedico(medico);
        }

        public DataTable BuscarMed(string texto)
        {

            return dm.BuscarMedico(texto);
        }

        public DataTable BuscarMedxSexo(string sexoseleccionado)
        {
            return dm.BuscarMedxSexo(sexoseleccionado);
        }

        public DataTable buscarMedxProvincia(string provincia)
        {
            return dm.BuscarMedxProvincia(provincia);
        }

        public DataTable buscarMedXEspecialidad(string especialidad)
        {
            return dm.BuscarMedxEspecialidad(especialidad);
        }

        public void BajaLogica(string LEG)
        {
            dm.BajaLogicaMedico(LEG);
        }

        public bool agregarMedico(string legajo, string dni, string nombre, string apellido, string sexo, string nacionalidad,
                          DateTime fechaNacimiento, string direccion, string codLocalidad, string codProvincia,
                          string correoElectronico, string telefono, string especialidad, string usuario, string tipousuario)
        {
            

            Medicos medico = new Medicos();
            medico.setLegajo_MED(legajo);
            medico.setDni_MED(dni);
            medico.setNombre_MED(nombre);
            medico.setApellido_MED(apellido);
            medico.setId_Sexo_MED(sexo);
            medico.setId_Nacionalidad_MED(nacionalidad);
            medico.setFecha_Nacimiento_MED(fechaNacimiento);
            medico.setDireccion_MED(direccion);
            medico.setCod_Localidad_MED(codLocalidad);
            medico.setCod_Provincia_MED(codProvincia);
            medico.setCorreo_Electronico_MED(correoElectronico);
            medico.setTelefono_MED(telefono);
            medico.setId_Especialidad_MED(especialidad);
            medico.setUsuario_MED(usuario);
            medico.setTipo_Usuario_MED(tipousuario);
            medico.setEstado_MED(true);

            return dm.agregarMedico(medico);
        }
        /*********************************************************************************/
        public DropDownList ObtenerDDLMedico(DropDownList Lista,string idespecialidad)
        {
           return dm.CargarMedico(Lista,idespecialidad);
        }
        /***********************************************************************************/
        public bool verificarExistencia(string legajo)
        {
            return dm.existeLegajoMED(legajo);
        }

    }
}
