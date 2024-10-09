using calculadora;

namespace calc{
    internal class Program{
        static void Main(string[] args){
            float valor1, valor2;
            float sub, div, mult;
            int menu;

            Operacoes calculadora = new Operacoes();

            do{

            Console.WriteLine("1-Soma.\n2-Subtração.\n3-Divisão.\n4-Multiplicação.");
            menu = Convert.ToInt32(Console.ReadLine());


                if (menu == 1) {
                    Console.WriteLine("Digite o valor da primeira variavel: ");
                    valor1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor da segunda variavel: ");
                    valor2 = float.Parse(Console.ReadLine());


                    calculadora.Soma(valor1, valor2);

                } else

                if (menu == 2) {

                    Console.WriteLine("Digite o valor da primeira variavel: ");
                    valor1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor da segunda variavel: ");
                    valor2 = float.Parse(Console.ReadLine());

                    calculadora.Sub(valor1, valor2);
                }
                else
                if (menu == 3) {


                    Console.WriteLine("Digite o valor da primeira variavel: ");
                    valor1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor da segunda variavel: ");
                    valor2 = float.Parse(Console.ReadLine());

                    calculadora.Div(valor1, valor2);
                }
                else
                if (menu == 4) {

                    Console.WriteLine("Digite o valor da primeira variavel: ");
                    valor1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor da segunda variavel: ");
                    valor2 = float.Parse(Console.ReadLine());

                    calculadora.Mult(valor1, valor2);

                }
                else {

                    Console.WriteLine("A opção selecionada não existe");

                }

            } while (menu != 0);

        }
    }
}
