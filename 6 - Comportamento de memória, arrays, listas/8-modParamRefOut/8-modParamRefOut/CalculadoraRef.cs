using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_modParamRefOut
{
    internal class CalculadoraRef
    {

        public static void Triple(ref int x)
        {
            x = x * 3;
        }

    }
}
