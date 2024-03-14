class Animal{ //classe base (pai)

    public void somAnimal(){
        Console.WriteLine("O animal faz um som");
    }

}

class Porco : Animal{ 
    public void somAnimal(){
        Console.WriteLine("O porco diz: Wee wee");
    }
}

class Cachorro : Animal{ 
    public void somAnimal() { Console.WriteLine("O cachorro diz: au au");
    }
}

class Programa{
    static void Main(string[] args){ 
        Animal meuAnimal = new Animal();
        Animal meuPorco = new Porco();
        Animal meuCachorro = new Cachorro();

        meuAnimal.somAnimal();
        meuPorco.somAnimal();
        meuCachorro.somAnimal();
    }
}