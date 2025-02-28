using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_03
{
    internal class Almacen
    {
        public string clave;
        public string nombre;
        public string ubicacion;
        public int cantidad ;

        public Almacen(string clave, string nombre, string ubicacion, int cantidad)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            this.cantidad = cantidad;
        }
    }
}
