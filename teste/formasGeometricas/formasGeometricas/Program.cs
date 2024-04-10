

using Classe;
using System.ComponentModel.Design;

class Programa{

    static void Main(string[] args){
        FormasGeometricas obj1 = new FormasGeometricas();

        int menu;


        do{

            Console.WriteLine("Escolha o que deseja fazer.\n1-calcular quadrado.\n2-calcular retangulo.\n3- calcular circulo\n0-Sair");
            menu = Convert.ToInt32(Console.ReadLine());

    

            switch (menu){

                case 1:
                    Console.WriteLine("Digite o lado do quadrado:");
                    obj1.QuadradoValor1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("{0}", obj1.quadradoArea());

                break;

                case 2:

                    Console.WriteLine("Digite a primeira lateral do retangulo: ");
                    obj1.RetanguloValor1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a segunda lateral do retangulo: ");
                    obj1.RetanguloValor2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("" + obj1.retanguloArea());

                break;

                case 3:

                    Console.WriteLine("Digite o diametro do circulo");
                    obj1.diametroCirculo = double.Parse(Console.ReadLine());

                    Console.WriteLine("" + obj1.circuloArea());

                break;


            }

        }while(menu != 0);

    }
}