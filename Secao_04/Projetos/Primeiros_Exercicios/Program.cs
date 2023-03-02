using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Primeiros_Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            /*Pessoa p1 = new Pessoa(), p2 = new Pessoa();
            Console.Write("Nome da primeira pessoa: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade da primeira pessoa: ");
            p1.idade = int.Parse(Console.ReadLine());
            Console.Write("Nome da segunda pessoa: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade da segunda pessoa: ");
            p2.idade = int.Parse(Console.ReadLine());
            if (p1.idade > p2.idade) Console.WriteLine("Pessoa mais velha: " + p1.nome);
            else if (p1.idade < p2.idade) Console.WriteLine("Pessoa mais velha: " + p2.nome);
            else Console.WriteLine(p1.nome + " e " + p2.nome + " tem a mesma idade.");*/

            //Ex2
            /*Funcionario f1 = new Funcionario(), f2 = new Funcionario();
            Console.Write("Nome da primeira pessoa: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salario da primeira pessoa: R$");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nome da segunda pessoa: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salario da segunda pessoa: R$");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double medio = 0.5 * (f1.salario + f2.salario);
            Console.WriteLine("Salário médio = R$" + medio.ToString("f2", CultureInfo.InvariantCulture));*/




        }
    }
}
