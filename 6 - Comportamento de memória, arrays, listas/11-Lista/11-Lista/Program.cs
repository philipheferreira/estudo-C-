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
            list.Add("Fernandinha");
            list.Add("HelloKit");
            list.Add("Anninha");

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
