using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Fixacao {
    class ConversorDeMoeda {
        static double Iof = 6 / 100;
        public static double ValorPago(double cotacao, double dolares) {
            return cotacao * dolares * (1 + Iof);
        }
    }
}
