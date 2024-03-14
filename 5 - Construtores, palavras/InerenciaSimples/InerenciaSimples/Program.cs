class Veiculo{

    public string montadora = "Ford";

    public void buzina(){
        Console.WriteLine("Biii, biii!");
    }

}


class Carro : Veiculo{
    public string modeloNome = "Mustang";
} 

class Programa{ 

    static void Main(string[] args){ 
    
        Carro meuCarro = new Carro();

        meuCarro.buzina();

        Console.WriteLine(meuCarro.montadora + " " + meuCarro.modeloNome);

    }

}