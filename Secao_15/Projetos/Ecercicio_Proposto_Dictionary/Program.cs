using System;
using System.IO;
using System.Net;

namespace Ecercicio_Proposto_Dictionary {
    internal class Program {
        static void Main(string[] args) {

            SortedDictionary<string, int> totalVotes = new SortedDictionary<string, int>();

            Console.WriteLine("Enter file full path: C:\\D2Ponto\\GoogleDrive\\Udemy\\C# Completo\\Secao_15\\Projetos\\Ecercicio_Proposto_Dictionary\\Input.csv");
            string path = @"C:\D2Ponto\GoogleDrive\Udemy\C# Completo\Secao_15\Projetos\Ecercicio_Proposto_Dictionary\Input.csv";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);

                        if (totalVotes.ContainsKey(name)) {
                            totalVotes[name] += votes;
                        }
                        else {
                            totalVotes[name] = votes;
                        }

                    }

                }
            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Votes extract");
            foreach (KeyValuePair<string, int> item in totalVotes) {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}