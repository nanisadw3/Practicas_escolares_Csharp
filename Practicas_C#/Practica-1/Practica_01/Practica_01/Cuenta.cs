using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_01
{
    internal class Cuenta
    {
        public int saldo;
        public string titular;
        public string numeroCuenta;
        public string anualidad;

        public Cuenta(int saldo, string titular, string numeroCuenta, string anualidad)
        {
            this.saldo = saldo;
            this.titular = titular;
            this.numeroCuenta = numeroCuenta;
            this.anualidad = anualidad;
        }
    }
}
