using System;
using System.Collections.Generic;


namespace Course {
    internal class Program {
        static void Main(string[] args) {
            HashSet<int> AlunosA = new HashSet<int>();
            HashSet<int> AlunosB = new HashSet<int>();
            HashSet<int> AlunosC = new HashSet<int>();


            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            while (n > 0) {
                AlunosA.Add(int.Parse(Console.ReadLine()));
                n--;
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            while (n > 0) {
                AlunosB.Add(int.Parse(Console.ReadLine()));
                n--;
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            while (n > 0) {
                AlunosC.Add(int.Parse(Console.ReadLine()));
                n--;
            }
            HashSet<int> Alunos = new HashSet<int>(AlunosA);
            Alunos.UnionWith(AlunosB);
            Alunos.UnionWith(AlunosC);
            Console.WriteLine("Total students: " + Alunos.Count + "\nStudents list:\n");
            PrintCollection(Alunos);
        }

        static void PrintCollection<T>(IEnumerable<T> collection) {
            foreach (T item in collection) {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}