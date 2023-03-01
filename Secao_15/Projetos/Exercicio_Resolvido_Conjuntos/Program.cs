using System;
using System.IO;
using System.Reflection.Metadata;
using System.Xml.Linq;
using Exercicio_Resolvido_Conjuntos.Entities;

namespace Exercicio_Resolvido_Conjuntos {
    internal class Program {
        static void Main(string[] args) {
            HashSet<LogRecord> set = new HashSet<LogRecord>();


            Console.WriteLine("Enter file full path: ");
            string path = @"C:\D2Ponto\GoogleDrive\Udemy\C# Completo\Secao_15\Projetos\Exercicio_Resolvido_Conjuntos\in.txt";
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(name, instant));
                    }

                    Console.WriteLine("Total users: "+set.Count);
                }
            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}