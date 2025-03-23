using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_10
{
    internal abstract class Bebida
    {
        public int temperatura = 13;

        //metodo abstracto
        public abstract string mostrarDescripcion();
        public void calentar(int temperatura)
        {
            this.temperatura += temperatura;
        }
    }
}
