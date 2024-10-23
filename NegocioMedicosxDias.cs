using Dao;// AGREGO LAS CLASES QUE
using Entidades;// VOY A USAR
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class NegocioMedicosxDias
    {
        DatosMedicosxDias DatosMXD = new DatosMedicosxDias();

        public bool agregarMedicoXDias( string Legajo, string Dia,DateTime hora)
        {
            int cantFilas = 0;

            Medicos_X_Dias MxD = new Medicos_X_Dias();
            MxD.Legajo1=Legajo;
            MxD.Dia1 = Dia;
            MxD.Hora = hora;
           
            DatosClinica dao = new DatosClinica();


            cantFilas = DatosMXD.agregarMedicoxDias(MxD);

            if (cantFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

    }
}
