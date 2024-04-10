using Classe;

class Programa{


    static void Main(String[] args){ 
    
        
        double numero1, numero2;
        int menu;


        do {

            Console.WriteLine("Digite a operação que quer realizar:\n1-Soma.\n2-Subtração.\n3-Multiplicação.\n4-Divisão.\n0-Sair");     
            menu = Convert.ToInt32(Console.ReadLine());
            switch (menu){
                case 1:
                    Console.WriteLine("Digite o valor do primeiro numero");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor do segundo numero");
                    numero2 = double.Parse(Console.ReadLine());

                    Calculadora obj1 = new Calculadora(numero1, numero2);

                    Console.WriteLine("O valor da soma é {0}", obj1.soma());

                break;

                case 2:

                    Console.WriteLine("Digite o valor do primeiro numero");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor do segundo numero");
                    numero2 = double.Parse(Console.ReadLine());

                    Calculadora obj2 = new Calculadora(numero1, numero2);

                    Console.WriteLine("O valor da subtração é " + obj2.sub());

                break;

                case 3:

                    Console.WriteLine("Digite o valor do primeiro numero");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor do segundo numero");
                    numero2 = double.Parse(Console.ReadLine());

                    Calculadora obj3 = new Calculadora(numero1, numero2);

                    Console.WriteLine("O valor da multiplicação é {0}", obj3.mult());

                break;

                case 4:

                    Console.WriteLine("Digite o valor do primeiro numero");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor do segundo numero");
                    numero2 = double.Parse(Console.ReadLine());

                    Calculadora obj4 = new Calculadora(numero1, numero2);

                    Console.WriteLine("O valor da subtração é " + obj4.div());

                    break;
            }
        } while (menu != 0);
    }
}