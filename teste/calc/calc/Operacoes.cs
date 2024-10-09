using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora{
    internal class Operacoes{
        public float Valor1, Valor2;

        public void SetValor1(float valor1){
            Valor1 = valor1;
        }

        public void SetValor2(float valor2){
            Valor2 = valor2; 
        }

        public float GetValor1(){
            return Valor1;
        }

        public float GetValor2(){
            return Valor2;
        }


        public void Soma(float valor1, float valor2){
            float soma = valor1 + valor2;

            Console.WriteLine("A soma de {0} e {1} resulta em {2}", valor1, valor2 ,soma);
        
        }

        public void Sub(float valor1, float valor2){
            float sub = valor1 - valor2;

            Console.WriteLine("A subtração de " + valor1 + " e " + valor2 + " resulta em "  + sub);

        }

        public void Div(float valor1, float valor2){
            float div = valor1 / valor2;

            Console.WriteLine($"A divisão de {valor1} e {valor2} resulta em {div}");
            

        }

        public void Mult(float valor1, float valor2){
            float mult = valor1 * valor2;

            Console.WriteLine("A multiplicação de {0} e {1} resulta em {2}", valor1, valor2, mult);

        }

    }
}
