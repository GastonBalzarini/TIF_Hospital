using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pacientes
    {
        private string DNIPaci;
        private string NombrePaci;
        private string ApellidoPaci;
        private string IDSexoPaci;
        private string IDNacPaci;
        private DateTime Fecha_Nac_Paci;
        private string DireccionPaci;
        private string CodLocPaci;
        private string CodProvPaci;
        private string CorreoElectPaci;
        private string TelefonoPaci;
        private bool EstadoPaci;

        public Pacientes()
        { 
        }

        //sets y gets
        public void setDNIPaci(string dniPaci)
        {
            DNIPaci = dniPaci;
        }
        public string getDNIPaci()
        {
            return DNIPaci;
        }

        public void setNombrePaci(string nombrePaci)
        {
            NombrePaci = nombrePaci;
        }
        public string getNombrePaci()
        {
            return NombrePaci;
        }

        public void setApellidoPaci(string apellidoPaci)
        {
            ApellidoPaci = apellidoPaci;
        }
        public string getApellidoPaci()
        {
            return ApellidoPaci;
        }

        public void setIDSexoPaci(string idSexoPaci)
        {
            IDSexoPaci = idSexoPaci;
        }
        public string getIDSexoPaci()
        {
            return IDSexoPaci;
        }

        public void setIDNacPaci(string idNacPaci)
        {
            IDNacPaci = idNacPaci;
        }
        public string getIDNacPaci()
        {
            return IDNacPaci;
        }
        
        public DateTime getFechaCPaci()
        {
            return Fecha_Nac_Paci;
        }
        public void setFechaNacPaci(DateTime fecha_Nac_Paci)
        {
            Fecha_Nac_Paci = fecha_Nac_Paci;
        }

        public void setDireccionPaci(string direccionPaci)
        {
             DireccionPaci = direccionPaci;
        }
        public string getDireccionPaci()
        {
            return DireccionPaci;
        }

        public void setCodLocPaci(string codLocPaci)
        {
            CodLocPaci = codLocPaci;
        }
        public string getCodLocPaci()
        {
            return CodLocPaci;
        }

        public void setCodProvPaci(string codProvPaci)
        {
            CodProvPaci = codProvPaci;
        }
        public string getCodProvPaci()
        {
            return CodProvPaci;
        }

        public void setCorreoElectPaci(string correoElectPaci)
        {
            CorreoElectPaci = correoElectPaci;
        }
        public string getCorreoElectPaci()
        {
            return CorreoElectPaci;
        }

        public void setTelefonoPaci(string telefonoPaci)
        {
            TelefonoPaci = telefonoPaci;
        }
        public string getTelefonoPaci()
        {
            return TelefonoPaci;
        }

        public void setEstadoPaci(bool estadoPaci)
        {
            EstadoPaci = estadoPaci;
        }
        public bool getEstadoPaci()
        {
            return EstadoPaci;
        }

    }
}
