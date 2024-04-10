using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe{
    class Calculadora{


        public double Valor1;
        public double Valor2;


        public Calculadora(double valor1, double valor2){ 
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public double soma(){
            return Valor1 + Valor2;
        }

        public double sub(){
            return Valor1 - Valor2;
        }

        public double mult(){
            return Valor1 * Valor2;
        }

        public double div(){
            return Valor1 / Valor2;
        }

    }
}
