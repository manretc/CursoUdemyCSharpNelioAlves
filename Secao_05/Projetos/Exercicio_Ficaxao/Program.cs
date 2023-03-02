using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_Ficaxao {
    class Program {
        static void Main(string[] args) {
            ContaBancaria conta;
            char sim_ou_nao = ' ';

            Console.Write("Entre o número da conta: ");
            ushort numconta = ushort.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titularconta = Console.ReadLine();
            while (!(sim_ou_nao == 's' || sim_ou_nao == 'n')) {
                Console.Write("Haverá depósito inicial (s/n)? ");
                sim_ou_nao = char.Parse(Console.ReadLine());
            }
            if (sim_ou_nao == 's') {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(titularconta, numconta, saldo);
            }
            else {
                conta = new ContaBancaria(titularconta, numconta);
            }
            Console.WriteLine(conta);
            Console.Write("Entre um valor para depósito: ");
            conta.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(conta);

            Console.Write("Entre um valor para saque: ");
            conta.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(conta);

        }
    }
}
