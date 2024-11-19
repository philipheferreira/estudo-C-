/*

Listas

* Lista é uma estrutura de dados:
    - Homogênea (dados do mesmo tipo)
    - Ordenada (Elementos acessados por meio de posições)
    - Inicia vazia, e seus elementos são alocados sob demanda
    - Cada elemento ocupa um "nó" (ou nodo) da lista

* Classe: List
* NameSpace: System.Collections.Generic


* Vantagens:
    - Tamanho Variável;
    - Facilidade para se realizar inserções e deleções

* Desvantagens:
    - Acesso Sequencial aos elementos


* Inserir elemento na lista: Add, Insert;
* Tamanho da lista: Count;
* Encontrar primeiro ou último elementos da lista que satisfaça um predicado: list.Find, list.FindLast;
* Encontrar primeira ou última
* Filtrar a lista com base em um predicado: list.FindAll;
* Remover elementos da lista: Remove, RemoveAll, RemoveAt, RemoveRange

*/



namespace _11_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            List<string> list2 = new List<string> { "Maria", "Alex" };

            list.Add("Joãozinho");
            list.Add("Alessandra");
            list.Add("Fernandinha");
            list.Add("Roberto");
            list.Add("HelloKit");
            list.Add("Aluizio");
            list.Add("Anninha");
            list.Add("João");
            list.Add("Farias");
            list.Add("Ana");

            foreach (string s in list) // passa por cada elemento da list definidos como s
            {
                Console.WriteLine(s);
            }

            Console.WriteLine($"Contagem da lista: {list.Count}"); // O comando Count verifica o numero total de itens na lista


            // INICIO DA FUNÇÃO FIND

            //Função Find espera um predicado como argumento

            string primeiroNomeA = list.Find(EncontraNomeComecaA); //Tem o objetivo de encontrar o primeiro elemento da lista que satisfaça um precidado
            Console.WriteLine("Primeiro nome que começa com a Letra A da lista: " + primeiroNomeA);

            string primeiroNomeF = list.Find(x => x[0] == 'F'); //Criando as condições dentro da chamada Find;
            Console.WriteLine("Primeiro nome que começa com a Letra F da lista: " + primeiroNomeF);

            //FIM DA FUNÇÃO FIND


            //INICIO DA FUNÇÃO FINDLAST

            string ultimoNomeA = list.FindLast(EncontraNomeComecaA);

            Console.WriteLine("Ultimo nome que começa com a Letra A da lista: " + ultimoNomeA);

            string ultimoNomeF = list.FindLast(x => x[0] == 'F');

            Console.WriteLine("Ultimo nome que começa com a Letra F da lista: " + ultimoNomeF);


            //FIM DA FUNÇÃO FINDLAST

            //INICIO DA FUNÇÃO FINDINDEX



            //FIM DA FUNÇÃO FINDINDEX


        }

        static bool EncontraNomeComecaA(string s)
        {
            return s[0] == 'A';
        }

    }
}
