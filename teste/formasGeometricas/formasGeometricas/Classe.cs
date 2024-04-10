using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe{
    internal class FormasGeometricas{

        public double QuadradoValor1;
        public double RetanguloValor1;
        public double RetanguloValor2;
        public double quadradoRetangulo;
        public double diametroCirculo;

        public double quadradoArea(){
            return QuadradoValor1 * QuadradoValor1;
        }

        public double retanguloArea(){
            return RetanguloValor1 * RetanguloValor2;
        }

        public double circuloArea(){
            return (diametroCirculo / 2) * (diametroCirculo / 2) * 3.14;
        }

    }
}
