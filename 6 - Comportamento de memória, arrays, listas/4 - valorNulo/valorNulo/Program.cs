using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); // esse comando é pra pegar o valor dentro da variavel e se não existir pegar o valor padrão dentro da variavel
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); //Faz um repasse da informação se x tem valor ou não
            Console.WriteLine(y.HasValue);

            Console.WriteLine(x.Value); // Pega a informação diretamente da variavel
            Console.WriteLine(y.Value);

            double a = x ?? 5; // Operador de coalecencia nulo: caso o valor de a esteja zerado ele vai jogar o valor 5
            double b = y ?? 5; // Operador de coalecencia nulo: caso o valor de a esteja zerado ele vai jogar o valor 5. Como y tem 10 nada será jogado
        }
    }
}