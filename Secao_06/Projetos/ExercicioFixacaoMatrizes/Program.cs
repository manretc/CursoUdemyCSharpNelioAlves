using System;

namespace ExercicioFixacaoMatrizes {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite os tamanhos da matriz: ");
            string[] tam = Console.ReadLine().Split(' ');
            int m = int.Parse(tam[0]);
            int n = int.Parse(tam[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++) {
                Console.WriteLine("Digite os valores da linha " + i + " da matriz:");
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);

                }
            }
            Console.Write("Digite um valor a ser buscado na matriz: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] == x) {
                        Console.WriteLine("Position " + i + ", " + j + ":");
                        if (j > 0) Console.WriteLine("Left: " + mat[i, j - 1]);
                        if (j < n - 1) Console.WriteLine("Right: " + mat[i, j + 1]);
                        if (i > 0) Console.WriteLine("Up: " + mat[i - 1, j]);
                        if (i < m - 1) Console.WriteLine("Down: " + mat[i + 1, j]);
                    }


                }
            }





        }

        static bool Test(string s) {
            return s[0] == 'A';
        }
    }
}
