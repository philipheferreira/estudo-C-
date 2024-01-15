using Enumeração.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeração.Entities{//já pegou o nome do projeto e o nome da pasta. Colocando em um outro namespace
    internal class Order{
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString(){
            return Id + " " + Moment + ", " + Status;
        }
    }
}
