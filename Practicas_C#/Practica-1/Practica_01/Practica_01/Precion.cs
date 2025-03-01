using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_01
{
    internal class Precion
    {
        private int sistolica;
        private int diastolica;

        public Precion(int sistolica, int diastolica)
        {
            this.sistolica = sistolica;
            this.diastolica = diastolica;
        }
        public string CalcularPrecion()
        {
            if (sistolica < 120 && diastolica < 80)
            {
                return "Normal";
            }
            else if (sistolica >= 120 && sistolica <= 129 && diastolica <= 80)
            {
                return "Elevada";
            }
            else if (sistolica > 129 && sistolica <= 139 && diastolica > 80 && diastolica <= 120)
            {
                return "Hipertensión 1";
            }
            else if (sistolica > 132 && sistolica <= 180 && diastolica > 90 && diastolica <= 120)
            {
                return "Hipertensión 1";
            }
            else if (sistolica > 180 && diastolica > 120)
            {
                return "crisis Hipotermica";
            }
            else
            {
                return "Error";
            }
        }
    }
}
