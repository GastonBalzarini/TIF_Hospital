using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace Dao
{
    public class DatosClinica
    {

        ConexionBD cn = new ConexionBD();
        public Boolean existeUsuario(Administradores_Y_Medicos obj)
        {
            ///Gracias al obj, se armara la consulta que servira como parametro
            String consulta = "Select * from Administradores_y_Medicos where Usuario_AYM ='" + obj.Usuario1 + "'AND Contraseña_AYM = '" + obj.Contraseña1 + "' AND Tipo_Usuario_AYM = '"+ obj.Tipo1+"'";
            ///llamo una funcion de la clase "CONEXIONBD"
            return cn.existe(consulta);
        }



    }
}
