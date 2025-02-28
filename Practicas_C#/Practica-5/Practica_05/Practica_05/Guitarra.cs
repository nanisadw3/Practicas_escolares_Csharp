using System;

namespace Practica_05
{
    internal class Guitarra : Instrumento
    {
        private int numeroCuerdas;

        public Guitarra(string clave, string nombre, float precio, int numeroCuerdas) : base(clave, nombre, precio)
        {
            // No es necesario reasignar clave, nombre y precio aquí porque ya lo hace el constructor base.
            this.numeroCuerdas = numeroCuerdas;
        }

        public int NumeroCuerdas
        {
            get { return numeroCuerdas; }
            set { numeroCuerdas = value; }
        }
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public override float CalcularPrecio()
        {
            return precio * 1.25f;  // Se agrega la 'f' para indicar que es un número de punto flotante
        }
    }
}
