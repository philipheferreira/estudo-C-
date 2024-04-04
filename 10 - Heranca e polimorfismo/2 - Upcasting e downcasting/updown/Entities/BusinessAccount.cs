using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace updown.Entities
{
    internal class BusinessAccount : Account{

        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public void Emprestimo(double valor){ 
            if (valor < LoanLimit){
                Balanco = valor;
            }
        }
    }
}
