using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using System.Data;
using Entidades;


namespace Negocio
{
    public class NegocioClinica
    {
        DatosClinica DC = new DatosClinica();
        public Boolean BuscarUsuario(Administradores_Y_Medicos obj)
        {
            ///Llamara una funcion de la clase "datosclinica" de la capa DAO
            ///tomando como parametro el obj
            return DC.existeUsuario(obj);
        }

     

       

        

    }
}
