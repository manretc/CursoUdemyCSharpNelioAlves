using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            /*
            int[] vect = new int[] { 10, 20, 30, 40 };
            Console.WriteLine(Calculator.Sum(10, 20, 30, 40));
            Console.WriteLine(Calculator.Sum(vect));
            Console.WriteLine(Calculator.Sum(10, 20, 30, 40, 50, 60, 70, 80, 90, 100));

            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            int b = 10, triplo;
            Calculator.Triple(b, out triplo);
            Console.WriteLine(triplo);
            
            int x = 10;
            object obj = 10;
            int y = (int)obj;


            string[] vect = new string[] { "Maria", "Bob", "Alex" };
            foreach (string obj in vect) {
                Console.WriteLine(obj);
            }
            */
            /*
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);
            string s1 = list.Find(x => x[0] == 'A');
            int i1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1 + ", Index: " + i1);
            string s2 = list.FindLast(x => x[0] == 'A');
            int i2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2 + ", Index: " + i2 + "\n-----------------------");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string item in list2) {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");
            foreach (string item in list) {
                if (item.Length == 5) Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");
            //list.Remove("Alex");
            //list.RemoveAt(2);
            list.RemoveRange(2, 2);
            foreach (string item in list) {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string item in list) {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");
            */

            Console.Write("Digite o tamanho da matriz: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            int negativos = 0;
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite os valores da linha " + i + " da matriz:");
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                    if (mat[i, j] < 0) negativos++;
                }
            }
            Console.WriteLine("Diagonal principal");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");

            }
            Console.WriteLine("\nNúmeros negativos: " + negativos);
            negativos = 0;
            foreach (int item in mat) {
                if (item < 0) negativos++;
            }
            Console.WriteLine("\nNúmeros negativos: " + negativos);

        }

        static bool Test(string s) {
            return s[0] == 'A';
        }
    }
}
