using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace updown.Entities{

    internal class Account{

        public int Numero { get; set; }

        public string Holder { get; set; }

        public double Balanco { get; set; }

        public Account(){ 
        
        }

        public Account(int numero, string holder, double balanco){ 
            Numero = numero;
            Holder = holder;
            Balanco = balanco;
        
        }

        public void Saque(double valor){ 
            Balanco -= valor;
        }

        public void Deposito(double valor){
            Balanco += valor;
        }

        public override string ToString(){
            return Holder + "" + Balanco + " " + Numero;
        }
    }
}
