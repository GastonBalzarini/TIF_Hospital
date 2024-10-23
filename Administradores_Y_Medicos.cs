using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administradores_Y_Medicos
    {
        private string Usuario;
        private string Contraseña;
        private string Tipo;
        private string Legajo;

        public string Usuario1 { get => Usuario; set => Usuario = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public string Legajo1 { get => Legajo; set => Legajo = value; }

        public  Administradores_Y_Medicos(){}
        public string getUsuario()
        {
            return Usuario;
        }

        public void setUsuario(string usuario)
        {
           Usuario = usuario;
        }

        public string getContraseña()
        {
            return Contraseña;
        }

        public void setContraseña(string contraseña)
        {
            Contraseña = contraseña;
        }

        public string getTipo()
        {
            return Tipo;
        }

        public void setTipo(string tipo)
        {
            Tipo = tipo;
        }

    }
}
