using System;

namespace _7_modificadorParametrosParams
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int s1 = Calculadora.Sum( new int[] { 2, 3 });
            int s2 = Calculadora.Sum( new int[] { 2, 4, 3 });

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
