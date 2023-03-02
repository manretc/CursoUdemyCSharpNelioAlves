using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            double num = 0, raiz = 0;
            Console.Write("Digite o numero:");
            num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (num >= 0) {

                raiz = Math.Sqrt(num);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite o numero:");
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            Console.WriteLine("Numero negativo");


        }

    }
}
