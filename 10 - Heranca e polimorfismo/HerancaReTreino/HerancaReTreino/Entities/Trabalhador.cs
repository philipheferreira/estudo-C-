using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaReTreino.Entities{
    internal class Trabalhador : Pessoa{
        public double HorarioDeTrabalho { get; set; }

        public Trabalhador() { }

        public Trabalhador(string nome, int idade, double totalDePassos) : base(nome, idade, totalDePassos){
            HorarioDeTrabalho = HorarioDeTrabalho;
        }

        public void Salto(double duploPasso){ 
            TotalDePassos = TotalDePassos + (duploPasso * 2);
        }
    }
}
