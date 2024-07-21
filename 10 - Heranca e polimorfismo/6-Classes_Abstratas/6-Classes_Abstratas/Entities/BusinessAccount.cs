using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Classes_Abstratas.Entities{
    class BusinessAccount : Account{

        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int numero, string holder, double  balanco, double loanLimit) : base (numero, holder, balanco){
            LoanLimit = loanLimit;
        }
        public void Emprestimo(double valor){
            if (valor < LoanLimit){
                Balanco = valor;
            }
        }
    }
}
