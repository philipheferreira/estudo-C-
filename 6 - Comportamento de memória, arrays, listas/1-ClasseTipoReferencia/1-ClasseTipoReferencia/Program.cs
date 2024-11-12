namespace ClasseExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Classe p1 = new Classe("TV", 900.00, 0);

            object p2;

            p2 = p1;

            Console.WriteLine(p2);
        }
    }
}
