using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_07
{
    internal class Asistencia : Persona
    {
        public string fecha;
        public int asistio;

        public Asistencia(string fecha, int asistio, string nombre)
        {
            this.fecha = fecha;
            this.asistio = asistio;
            this.nombre = nombre;
        }
    }
}
