namespace _8_modParamRefOut
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
            CalculadoraOut.Triple(a, out triple);
            Console.WriteLine(triple);

        }
    }
}
