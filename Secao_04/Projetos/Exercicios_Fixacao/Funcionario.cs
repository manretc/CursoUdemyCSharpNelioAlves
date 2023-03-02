using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios_Fixacao {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public void AumentarSalario(double porcentagem) {
            SalarioBruto *= (1 + porcentagem / 100);
        }

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public override string ToString() {
            return "Funcionario: " + Nome
                + ", R$" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
