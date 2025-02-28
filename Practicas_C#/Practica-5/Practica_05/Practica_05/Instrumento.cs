using System;

namespace Practica_05
{
    internal class Instrumento
    {
        protected string clave;  // Protegidos para ser accesibles en clases derivadas
        protected string nombre;
        protected float precio;

        public Instrumento(string clave, string nombre, float precio)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.precio = precio;
        }

        public virtual float CalcularPrecio() 
        {
            return precio;
        }

    }
}
