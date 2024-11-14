using testeOut;
using testeRef;

namespace _8_modificadoresdeParametrosrefeout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            CalculadoraRef.Triple(ref a);
            Console.WriteLine(a);

            int b = 20;
            int triple;
            CalculadoraOut.Triple(b, out triple);
            Console.WriteLine(triple);

        }
    }
}
