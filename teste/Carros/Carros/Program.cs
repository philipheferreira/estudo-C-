
class Carro{

    public string Cor;
    public string Marca;
    public string Modelo;

    public Carro(string cor, string marca, string modelo){
        Cor = cor;
        Marca = marca;
        Modelo = modelo;
    }

    public override string ToString(){
        return Modelo + ", " + Marca + ", " + Cor;
    }

    static void Main(string[] args){

        Carro carro1 = new Carro("Azul", "Ford", "Fusca");


        Console.WriteLine(carro1);

    }
}