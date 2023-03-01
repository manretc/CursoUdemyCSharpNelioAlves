using System;
using System.Globalization;

namespace Exercicio1_Estrutura_Sequencial {
    class Program {
        static void Main(string[] args) {

            //Ex1:
            /* Console.WriteLine("Digite os valores:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int soma = a + b;

            Console.WriteLine("Valor da soma: " + soma); */

            //Ex2:
            /* double pi = 3.14159, raio, area;
             Console.WriteLine("Digite o raio:");
             raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             area = pi * Math.Pow(raio, 2);
             Console.WriteLine("Area: " + area.ToString("F4", CultureInfo.InvariantCulture));*/

            //Ex3:
            /*int a, b, c, d, diferenca;
            Console.WriteLine("Digite os valores:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            diferenca = a*b-c*d;
            Console.WriteLine("Diferenca: " + diferenca);*/

            //Ex4:
            /*Console.WriteLine("Digite o numero do funcionario: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de horas trabalhadas pelo funcionario: ");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor por hora que o funcionario recebe:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = valor * horas;
            Console.WriteLine("Numero: "+num);
            Console.WriteLine("Salario: U$"+salario.ToString("F2", CultureInfo.InvariantCulture));*/

            //Ex5:
            /*Console.WriteLine("Digite o codigo da peca 1: ");
            int cod1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de pecas do tipo 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitario da peca tipo 1:");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o codigo da peca 2: ");
            int cod2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de pecas do tipo 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitario da peca tipo 2:");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valortotal = valor1*num1 + valor2*num2;
            Console.WriteLine("Valor total: R$" + valortotal.ToString("F2", CultureInfo.InvariantCulture));*/

            //Ex6:
            /*double a, b, c, atriag, acirc, atrap, aquad, aret, pi = 3.14159;
            Console.WriteLine("Digite os valores: ");
            string[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            atriag = a * c / 2;
            acirc = pi * c * c;
            atrap = c*(a+b)/2;
            aquad = b*b;
            aret = a*b;

            Console.WriteLine("Triangulo: "+atriag.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo: " + acirc.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio: " + atrap.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + aquad.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retangulo: " + aret.ToString("F3", CultureInfo.InvariantCulture));*/

        }
    }
}
