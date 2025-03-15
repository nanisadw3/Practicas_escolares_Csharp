using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_09
{
    internal class Registros
    {
        public string usuario;
        public string password;

        public Registros(string usuario, string password)
        {
            this.usuario = usuario;
            this.password = password;
        }
    }
}
