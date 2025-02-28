using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_06
{
    internal class Usuario
    {
        string usuario;
        string password;
        string fecha;

        public Usuario(string usuario, string password, string fecha)
        {
            this.usuario = usuario;
            this.password = password;
            this.fecha = fecha;
        }

    }
}
