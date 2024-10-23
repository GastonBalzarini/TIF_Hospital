using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Turnos
    {
        private Medicos_X_Dias Turno;
        private string Dni_Paciente;
        private char Asistencia;
        private string Observacion;

        public Turnos() { }

        public string Dni_Paciente1 { get => Dni_Paciente; set => Dni_Paciente = value; }
        public char Asistencia1 { get => Asistencia; set => Asistencia = value; }
        public string Observacion1 { get => Observacion; set => Observacion = value; }
        internal Medicos_X_Dias Turno1 { get => Turno; set => Turno = value; }
    }
}
