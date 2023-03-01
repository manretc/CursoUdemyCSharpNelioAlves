using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios_Fixacao {
    class Program {
        static void Main(string[] args) {

            //Ex1
            /*Retangulo r = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(r);*/

            //Ex2
            /*Funcionario f = new Funcionario();
            Console.WriteLine("Entre com os dados do funcionario: ");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(f);
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcentagem);
            Console.WriteLine(f);*/

            //Ex3
            /*Aluno a = new Aluno();
            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.NotaT1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.NotaT2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.NotaT3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(a);*/

            //Ex4
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em reais = R$" 
                + ConversorDeMoeda.ValorPago(cotacao, dolares).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
