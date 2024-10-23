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
    public class NegocioAdmYMed
    {
        DaoMedYAdm dm = new DaoMedYAdm();



        public bool modificarMedico(string usuario, string contraseña)
        {
            int cantFilas = 0;

            Administradores_Y_Medicos medico = new Administradores_Y_Medicos();

            medico.setUsuario(usuario);
            medico.setContraseña(contraseña);

            cantFilas = dm.ActualizarAdmYMed(medico);

            if (cantFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
 public bool modificarUsuario( string usuarioNuevo, string legajo)
        {
            return dm.modUsuario(usuarioNuevo, legajo);

        }


        public bool agregarUsuario(string usuario, string contra, string tipo)
        {
            Administradores_Y_Medicos aym = new Administradores_Y_Medicos();
            aym.setUsuario(usuario);
            aym.setContraseña(contra);
            aym.setTipo(tipo);

            return dm.agregarUsuario(aym);
        }

        public bool verificarExistencia(string usuario)
        {
            return dm.verificarUsuario(usuario);
        }


    }
}
