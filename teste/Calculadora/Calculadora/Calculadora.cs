using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe{
    class Calculadora{


        private double _Valor1;
        private double _Valor2;


        public Calculadora(double valor1, double valor2){ 
            _Valor1 = valor1;
            _Valor2 = valor2;
        }

        public double GetValor1(){
            return _Valor1;
        }

        public double GetValor2(){ 
            return _Valor2;
        }

        public void SetValor1(double valor1){
            _Valor1 = valor1;
        }

        public void SetValor2(double valor2){ 
            _Valor2 = valor2;
        }

        public double soma(){
            return _Valor1 + _Valor2;
        }

        public double sub(){
            return _Valor1 - _Valor2;
        }

        public double mult(){
            return _Valor1 * _Valor2;
        }

        public double div(){
            return _Valor1 / _Valor2;
        }

    }
}
