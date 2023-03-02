using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio4_Estrutura_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            /*int x = 0;
            Console.WriteLine("Digite o valor: ");
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i+=2)
            {
                Console.WriteLine(i);
            }*/

            //Ex2
            /*int in_ = 0, out_ = 0, x, y;
            Console.Write("Digite a quantidade de numeros: ");
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                Console.Write($"Digite o numero #{i}: ");
                y = int.Parse(Console.ReadLine());
                if (y >= 10 && y <= 20) in_++;
                else out_++;
            }
            Console.WriteLine($"{in_} in");
            Console.WriteLine($"{out_} out");*/

            //Ex3
            /*int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);
                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }*/

            //Ex4
            /*int n = int.Parse(Console.ReadLine());
            double div = 0;
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                if (b != 0)
                {
                    div = a / b;
                    Console.WriteLine(div.ToString("F2", CultureInfo.InvariantCulture));
                }
                else Console.WriteLine("Divisao impossivel.");
            }*/

            //Ex5
            /*int n, f = 1;
            Console.Write("Digite o numero: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            Console.WriteLine("Fatorial: "+f);*/

            //Ex6
            /*int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            //Ex7
            /*int n = int.Parse(Console.ReadLine());
            int quad = 0, cubo = 0;
            for (int i = 1; i <= n; i++)
            {
                quad = (int)Math.Pow(i, 2);
                cubo = (int)Math.Pow(i, 3);
                Console.WriteLine(i + " " + quad + " " + cubo);
            }*/

        }
    }
}
