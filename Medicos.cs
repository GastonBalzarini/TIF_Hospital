using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medicos
    {
        private string Legajo_MED;
        private string Dni_MED;
        private string Nombre_MED;
        private string Apellido_MED;
        private string Id_Sexo_MED;
        private string Id_Nacionalidad_MED;
        private DateTime Fecha_Nacimiento_MED;
        private string Direccion_MED;
        private string Cod_Localidad_MED;
        private string Cod_Provincia_MED;
        private string Correo_Electronico_MED;
        private string Telefono_MED;
        private string Id_Especialidad_MED;
        private string Usuario_MED;
        private string Tipo_Usuario_MED;
        private bool Estado_MED;

        public Medicos()
        { }

  

        public string getDni_MED()
        {
            return Dni_MED;
        }

        public void setDni_MED(string dni_MED)
        {
            Dni_MED = dni_MED;
        }

        public string getNombre_MED()
        {
            return Nombre_MED;
        }

        public void setNombre_MED(string nombre_MED)
        {
            Nombre_MED = nombre_MED;
        }

        public string getApellido_MED()
        {
            return Apellido_MED;
        }

        public void setApellido_MED(string apellido_MED)
        {
            Apellido_MED = apellido_MED;
        }

        public string getId_Sexo_MED()
        {
            return Id_Sexo_MED;
        }

        public void setId_Sexo_MED(string id_Sexo_MED)
        {
            Id_Sexo_MED = id_Sexo_MED;
        }

        public string getId_Nacionalidad_MED()
        {
            return Id_Nacionalidad_MED;
        }

        public void setId_Nacionalidad_MED(string id_Nacionalidad_MED)
        {
            Id_Nacionalidad_MED = id_Nacionalidad_MED;
        }

        public DateTime getFecha_Nacimiento_MED()
        {
            return Fecha_Nacimiento_MED;
        }

        public void setFecha_Nacimiento_MED(DateTime fecha_Nacimiento_MED)
        {
            Fecha_Nacimiento_MED = fecha_Nacimiento_MED;
        }

        public string getDireccion_MED()
        {
            return Direccion_MED;
        }

        public void setDireccion_MED(string direccion_MED)
        {
            Direccion_MED = direccion_MED;
        }

        public string getCod_Localidad_MED()
        {
            return Cod_Localidad_MED;
        }

        public void setCod_Localidad_MED(string cod_Localidad_MED)
        {
            Cod_Localidad_MED = cod_Localidad_MED;
        }

        public string getCod_Provincia_MED()
        {
            return Cod_Provincia_MED;
        }

        public void setCod_Provincia_MED(string cod_Provincia_MED)
        {
            Cod_Provincia_MED = cod_Provincia_MED;
        }

        public string getCorreo_Electronico_MED()
        {
            return Correo_Electronico_MED;
        }

        public void setCorreo_Electronico_MED(string correo_Electronico_MED)
        {
            Correo_Electronico_MED = correo_Electronico_MED;
        }

        public string getTelefono_MED()
        {
            return Telefono_MED;
        }

        public void setTelefono_MED(string telefono_MED)
        {
            Telefono_MED = telefono_MED;
        }

        public string getId_Especialidad_MED()
        {
            return Id_Especialidad_MED;
        }

        public void setId_Especialidad_MED(string id_Especialidad_MED)
        {
            Id_Especialidad_MED = id_Especialidad_MED;
        }

        public string getUsuario_MED()
        {
            return Usuario_MED;
        }

        public void setUsuario_MED(string usuario_MED)
        {
            Usuario_MED = usuario_MED;
        }

        public string getTipo_Usuario_MED()
        {
            return Tipo_Usuario_MED;
        }

        public void setTipo_Usuario_MED(string tipo_Usuario_MED)
        {
            Tipo_Usuario_MED = tipo_Usuario_MED;
        }

        public bool getEstado_MED()
        {
            return Estado_MED;
        }

        public void setEstado_MED(bool estado_MED)
        {
            Estado_MED = estado_MED;
        }

        public void setLegajo_MED(string legajo)
        {
            this.Legajo_MED = legajo;
        }

        public string getLegajo_MED()
        {
            return this.Legajo_MED;
        }


    }
}

