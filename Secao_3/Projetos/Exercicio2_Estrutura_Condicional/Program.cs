using System;
using System.Globalization;

namespace Exercicio2_Estrutura_Condicional {
    class Program {
        static void Main(string[] args) {

            //Ex1:
            /*int num = 0;
            Console.WriteLine("Digite o número!");
            num = int.Parse(Console.ReadLine());
            if(num < 0) Console.WriteLine("Negativo!");
            else Console.WriteLine("Nao Negativo!");*/

            //Ex2:
            /*int num = 0;
            Console.WriteLine("Digite o número!");
            num = int.Parse(Console.ReadLine());
            if (num%2 == 0) Console.WriteLine("Par!");
            else Console.WriteLine("Impar!");*/

            //Ex3:
            /*int x = 0, y = 0;
            Console.WriteLine("Digite os números!");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if (x > y) {
                if (x % y == 0) Console.WriteLine("Sao Multiplos!");
                else Console.WriteLine("Nao Sao Multiplos!");
            }
            else {
                if (y % x == 0) Console.WriteLine("Sao Multiplos!");
                else Console.WriteLine("Nao Sao Multiplos!");
            }*/

            //Ex4:
            /*int h1 = 0, h2 = 0, dur = 0;
            Console.WriteLine("Digite a hora inicial:");
            h1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hora final:");
            h2 = int.Parse(Console.ReadLine());
            if (h1 < h2) dur = h2 - h1;
            else dur = 24 - h1 + h2;
            Console.WriteLine("O jogo durou " + dur + " horas!");*/

            //Ex5:
            /*double[] prod = { 4.0, 4.5, 5.0, 2.0, 1.5 };
            double valor = 0;
            int cod = 0, quant = 0;
            Console.WriteLine("Digite o código:");
            cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade:");
            quant = int.Parse(Console.ReadLine());
            valor = quant * prod[cod - 1];
            Console.WriteLine("Total: R$"+valor.ToString("F2"));*/

            //Ex6:
            /*double valor = 0;
            Console.WriteLine("Digite o valor:");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor >= 0 && valor <= 25) Console.WriteLine("Intervalo [0,25]");
            else if (valor > 25 && valor <= 50) Console.WriteLine("Intervalo (25,50]");
            else if (valor > 50 && valor <= 75) Console.WriteLine("Intervalo (50,75]");
            else if (valor > 75 && valor <= 100) Console.WriteLine("Intervalo (75,100]");
            else Console.WriteLine("Fora de Intervalo");*/

            //Ex7:
            /*double x = 0, y = 0;
            Console.WriteLine("Digite os números!");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (x == 0 && y == 0) Console.WriteLine("Origem!");
            else if (x == 0 && y != 0) Console.WriteLine("Eixo Y!");
            else if (x != 0 && y == 0) Console.WriteLine("Eixo X!");
            else if (x > 0 && y > 0) Console.WriteLine("Q1!");
            else if (x < 0 && y > 0) Console.WriteLine("Q2!");
            else if (x < 0 && y < 0) Console.WriteLine("Q3!");
            else if (x > 0 && y < 0) Console.WriteLine("Q4!");*/

            //Ex8:
            /*double sal = 0, imp = 0;
            Console.WriteLine("Digite o salário!");
            sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (sal > 4500) {
                imp = (3000 - 2000.01) * 0.08 + (4500 - 3000.01) * 0.18 + (sal - 4500) * 0.28;
                Console.WriteLine("R$" + imp.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (sal > 3000.01) {
                imp = (3000 - 2000.01) * 0.08 + (sal - 3000.01) * 0.18;
                Console.WriteLine("R$" + imp.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (sal > 2000.01) {
                imp = (sal - 2000.01) * 0.08;
                Console.WriteLine("R$" + imp.ToString("F2", CultureInfo.InvariantCulture));
            }
            else Console.WriteLine("Isento.");*/

        }

    }
}
