using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_10
{
    internal class Cafe : Bebida
    {
        public override string mostrarDescripcion()
        {
            return "Esto es un Cafe con una temperatura de " + temperatura;
        }
    }
}
