namespace calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valor1, valor2;
            float soma, sub, div, mult;

            Console.WriteLine("Digite o valor da primeira variavel: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da segunda variavel: ");
            valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine($" O valor inserido para a primeira variavel é {valor1} e o segundo é {valor2} ");
            
            soma = valor1 + valor2;

            sub = valor1 - valor2;

            div = valor1 / valor2;

            mult = valor1 * valor2;

            Console.WriteLine("Operações:\nSoma: " + soma + "\nSubtração: " + sub + "\nDivisão: " + div + "\nMultiplicação: " + mult);

        }
    }
}
