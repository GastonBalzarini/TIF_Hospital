using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using System.Data;
using Entidades;
using System.Web.UI.WebControls;

namespace Negocio
{
    public class NegocioPacientes
    {
        DaoPacientes mc = new DaoPacientes();

        public DataTable ObtenerTablaPacientes()
        {
            return mc.TablaPacientes();
        }

        public DropDownList ObtenerDDlPacientes(DropDownList Lista)
        {
            return mc.DDLPacientes( Lista);
        }
        public DataTable BuscarPac(string IDDNI)
        {

            return mc.BuscarPaciente(IDDNI);
        }

        public DataTable BuscarPacxSexo(string sexoSeleccionado)
        {
            return mc.BuscarPacxSexo(sexoSeleccionado);
        }

        public DataTable BuscarPacxLocalidad(string provincia)
        {
            return mc.BuscarPacxLocalidad(provincia);
        }

        public void BajaLogica(string DNI)
        {
            mc.BajaLogicaPaciente(DNI);
        }

        public void altaLogica(string DNI)
        {
            mc.altaLogicaPaciente(DNI);
        }

        public bool agregarPaciente(string dni, string nombre, string apellido, string sexo, string nacionalidad,
                      DateTime fechaNacimiento, string direccion, string codLocalidad, string codProvincia,
                      string correoElectronico, string telefono)
        {
            int cantFilas = 0;

            Pacientes pac = new Pacientes();

            pac.setDNIPaci(dni);
            pac.setNombrePaci(nombre);
            pac.setApellidoPaci(apellido);
            pac.setIDSexoPaci(sexo);
            pac.setIDNacPaci(nacionalidad);
            pac.setFechaNacPaci(fechaNacimiento);
            pac.setDireccionPaci(direccion);
            pac.setCodLocPaci(codLocalidad);
            pac.setCodProvPaci(codProvincia);
            pac.setCorreoElectPaci(correoElectronico);
            pac.setTelefonoPaci(telefono);
            pac.setEstadoPaci(true);

            cantFilas = mc.agregarPaciente(pac);

            if (cantFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Actualizar(Pacientes pac)
        {
            return mc.ActualizarPaciente(pac);
        }

        public bool verificarExistencia(string dni)
        {
            return mc.existeDNI(dni);
        }

        public bool dadoDeBaja(string dni)
        {
            return mc.existeRegElim(dni);
        }
    }
}
