using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_02
{
    internal class Empleado
    {
        public string clave;
        public string nombre;
        public string ap;
        public string am;
        public string salario;
        string correo;

        public Empleado(string clave, string nombre, string ap, string am, string salario)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.ap = ap;
            this.am = am;
            this.salario = salario;
        }
        public string generarCorreo() {
            
                correo = nombre.Substring(0, 1) + primeraVocal(ap) + nombre + "@empresa.com";
                return correo;
            

        }
        private char primeraVocal(string cadena)
        {
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < cadena.Length; i++)
            {
                if (vocales.Contains(cadena[i]))
                {
                    return cadena[i];
                }
            }
            return ' ';
        }
    }
}
