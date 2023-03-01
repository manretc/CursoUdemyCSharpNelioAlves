using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios_Fixacao {
    class Aluno {
        public string Nome;
        public double NotaT1, NotaT2, NotaT3;

        public double NotaFinal() {
            return NotaT1 + NotaT2 + NotaT3;
        }

        public string Situacao() {
            if (NotaFinal() >= 60) {
                return "NOTA FINAL = " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                        + "\nAPROVADO";
            }
            else {
                double falta = 60 - NotaFinal();
                return "NOTA FINAL = " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                        + "\nREPROVADO"
                        + "\nFALTARAM " + falta.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }
        }

        public override string ToString() {
            return Situacao();
        }
    }
}
