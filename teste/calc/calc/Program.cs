namespace calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valor1, valor2;

            Console.WriteLine("Digite o valor da primeira variavel: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da segunda variavel: ");
            valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine($" O valor inserido para a primeira variavel é {valor1} e o segundo é {valor2} ");

        }
    }
}
