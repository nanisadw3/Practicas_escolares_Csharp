using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_01
{
    internal class Calcular
    {
        public int distancia;
        public int tiempo;

        public Calcular(int distancia, int tiempo)
        {
            this.distancia = distancia;
            this.tiempo = tiempo;
        }

        public int CalcularVelocidad()
        {
            return distancia / tiempo;
        }
    }
}
