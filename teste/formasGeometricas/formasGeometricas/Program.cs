

using System.ComponentModel.Design;

class Formas{
    public double quadradoValor1;
    public double retanguloValor1;
    public double retanguloValor2;
    public double quadradoRetangulo;

    public double quadradoArea(){
        return quadradoValor1 * quadradoValor1;
    }

    public double retanguloArea(){
        return retanguloValor1 * retanguloValor2;
    }

    static void Main(string[] args){
        Formas obj1 = new Formas();

        int menu;


        do{

            Console.WriteLine("Escolha o que deseja fazer.\n1-calcular quadrado.\n2-calcular retangulo.\n0-Sair");
            menu = Convert.ToInt32(Console.ReadLine());

    

            switch (menu){

                case 1:
                    Console.WriteLine("Digite o lado do quadrado:");
                    obj1.quadradoValor1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("{0}", obj1.quadradoArea());

                break;

                case 2:

                    Console.WriteLine("Digite a primeira lateral do retangulo: ");
                    obj1.retanguloValor1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a segunda lateral do retangulo: ");
                    obj1.retanguloValor2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("" + obj1.retanguloArea());

                break;

                case 3:

                break;


            }

        }while(menu != 0);

    }
}