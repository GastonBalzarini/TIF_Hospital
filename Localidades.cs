using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Localidades
    {
        private string Id_Localidad;
        private Provincias Id_Provincia;
        private string Nombre;

        public Localidades()
        {

        }

        //GETS Y SETS
        public string Id_Localidad1 { get => Id_Localidad; set => Id_Localidad = value; }

        public Provincias Id_Provincia1
        {
            get => Id_Provincia;
            set => Id_Provincia = value;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
    }
}
