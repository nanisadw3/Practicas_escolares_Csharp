using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_09
{
    internal class MiExepcionCampoVacio : Exception
    {
        public MiExepcionCampoVacio(string message) : base(message)
        {
        }
    }
}
