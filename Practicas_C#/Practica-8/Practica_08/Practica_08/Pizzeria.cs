using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_08
{
    internal class Pizzeria
    {

        private string clave;
        private string estatus;
        private string repartidor;

        public Pizzeria(string clave, string estatus, string repartidor)
        {
            this.clave = clave;
            this.estatus = estatus;
            this.repartidor = repartidor;
        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public string Estatus
        {
            get { return estatus; }
            set { estatus = value; }
        }

        public string Repartidor
        {
            get { return repartidor; }
            set { repartidor = value; }
        }
    }
}
