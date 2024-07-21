using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Classes_Abstratas.Entities{
    class SavingsAccount : Account{
        public double InterestRate {  get; set; }
        public SavingsAccount(){ }
        public SavingsAccount(int numero, string holder, double balanco, double interestRate) : base(numero, holder, balanco){
            InterestRate = interestRate;
        }

        public void UpdateBalance(){
            Balanco += Balanco * InterestRate;
        }

        public void Withdraw(double amount){
            Balanco -= amount;
        }
    }
}
