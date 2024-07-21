using _6_Classes_Abstratas.Entities;
using System.Collections.Generic; // serve para poder utilizar como lista

namespace Treino{
    class Programa{
        static void Main(string[] args){
            List<Account> list = new List<Account>(); // usar o account que é uma classe abstrata como uma lista
            list.Add(new SavingsAccount(1001, "João", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "", 500.00, 400.00));
            list.Add(new SavingsAccount(1003, "", 500.00, 0.02));
            list.Add(new BusinessAccount(1004, "", 500.00, 300.00));
        }          
    }
}