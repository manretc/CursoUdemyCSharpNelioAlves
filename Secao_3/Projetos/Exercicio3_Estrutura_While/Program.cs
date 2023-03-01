using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio3_Estrutura_While
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ex1
            /*int senha = 2002, tentativa;
            Console.WriteLine("Digite a senha: ");
            tentativa = int.Parse(Console.ReadLine());
            while (senha != tentativa)
            {
                Console.WriteLine("Senha invalida.");
                Console.WriteLine("Digite a senha: ");
                tentativa = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitdo.");*/

            //Ex2
            /*double x = 0, y = 0;
            Console.WriteLine("Digite os números!");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0) Console.WriteLine("Q1!");
                else if (x < 0 && y > 0) Console.WriteLine("Q2!");
                else if (x < 0 && y < 0) Console.WriteLine("Q3!");
                else if (x > 0 && y < 0) Console.WriteLine("Q4!");
                Console.WriteLine("Digite os números!");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }*/

            //Ex3
            /*int[] vet = { 0, 0, 0, 0, 0 };
            int tipo = 0;
            while (tipo != 4)
            {
                Console.Write("Digite o tipo de combustivel: ");
                tipo = int.Parse(Console.ReadLine());
                if (tipo > 0 && tipo < 4) vet[tipo]++;
            }
            Console.WriteLine("Muito obrigado");
            Console.WriteLine("Alcool: " + vet[1]);
            Console.WriteLine("Gasolina: " + vet[2]);
            Console.WriteLine("Diesel: " + vet[3]);*/

            //Ex4




        }
    }
}
