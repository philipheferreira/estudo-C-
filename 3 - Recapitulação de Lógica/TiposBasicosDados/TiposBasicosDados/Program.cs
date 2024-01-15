using System;
using System.Globalization;


namespace PrimeiroProjeto{
    class Programa{
        static void Main(string[] args){
            bool teste = true;
            byte n1 = 1;
            int idade = 27;
            double saldo = 2000;
            string nome = "Philiphe";
            char genero = 'M';

            Console.WriteLine("Ola, {0} como está seu dia?", nome); // Primeira forma de declarar comunicação output
            Console.WriteLine( "Você tem " + idade + " anos"); // segunda forma de declarar comunicação output
            Console.WriteLine($"seu byte tem o valor de {n1} e seu saldo é de {saldo}"); // Terceira forma de declarar comunicação output
        
            
        }
    }
}


