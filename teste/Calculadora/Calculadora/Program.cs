

class Calculadora{

    public double valor1;
    public double valor2;

    public double soma(){ 
        return valor1 + valor2;
    }

    public double sub() { 
        return valor1 - valor2;
    }

    public double mult() { 
        return valor1 * valor2;
    }

    public double div() { 
        return valor1 / valor2;
    }

    static void Main(String[] args){ 
    
        Calculadora obj1 = new Calculadora();
        
        int menu;


        do {



            Console.WriteLine("Digite a operação que quer realizar:\n1-Soma.\n2-Subtração.\n3-Multiplicação.\n4-Divisão.\n0-Sair");     
            menu = Convert.ToInt32(Console.ReadLine());
            switch (menu){
                case 1:
                    Console.WriteLine("Digite o valor do primeiro numero");
                    obj1.valor1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor do segundo numero");
                    obj1.valor2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("O valor da soma é {0}", obj1.soma());

                break;

                case 2:

                    Console.WriteLine("Digite o valor do primeiro numero");
                    obj1.valor1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor do segundo numero");
                    obj1.valor2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("O valor da subtração é " + obj1.sub());

                break;

                case 3:

                    Console.WriteLine("Digite o valor do primeiro numero");
                    obj1.valor1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor do segundo numero");
                    obj1.valor2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("O valor da multiplicação é {0}", obj1.mult());

                break;

                case 4:

                    Console.WriteLine("Digite o valor do primeiro numero");
                    obj1.valor1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor do segundo numero");
                    obj1.valor2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("O valor da subtração é " + obj1.div());

                    break;
            }
        } while (menu != 0);
    }
}