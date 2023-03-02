using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_Ficaxao {
    class ContaBancaria {

        private string _titularConta;
        private double _taxa;
        public ushort NumConta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria() {
            Saldo = 0;
            _taxa = 5.0;
        }
        public ContaBancaria(string titularconta, ushort numconta)
            : this() {
            TitularConta = titularconta;
            NumConta = numconta;
        }
        public ContaBancaria(string titularconta, ushort numconta, double depositoInicial)
            : this(titularconta, numconta) {
            Deposito(depositoInicial);
        }

        public string TitularConta {
            get { return _titularConta; }
            set {
                if (value != null && value.Length > 1) {
                    _titularConta = value;
                }
            }
        }

        public void Deposito(double deposito) {
            Saldo += deposito;
        }
        public void Saque(double saque) {
            Saldo -= saque + _taxa;
        }


        public override string ToString() {
            return "Dados da conta atualizados:\n"
                + "Conta: " + NumConta
                + ", Titular: " + TitularConta
                + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
