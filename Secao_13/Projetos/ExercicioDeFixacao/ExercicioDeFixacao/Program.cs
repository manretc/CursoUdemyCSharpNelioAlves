using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solução Manre
            string sourcePath = @"C:\D2Ponto\GoogleDrive\Udemy\C# Completo\Secao_13\Projetos\Exercicio\entrada.csv";
            string targetPath = @"C:\D2Ponto\GoogleDrive\Udemy\C# Completo\Secao_13\Projetos\Exercicio\out\summary.csv";

            FileInfo fileInfo = new FileInfo(sourcePath);
            FileInfo fileInfo2 = new FileInfo(targetPath);
            
            string[] lines = File.ReadAllLines(sourcePath);
            List<string[]> list = new List<string[]>();
            foreach (string line in lines)
            {
                list.Add(line.Split(','));
            }

            try
            {
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string[] item in list)
                    {
                        double a = double.Parse(item[1]);
                        double b = double.Parse(item[2]);
                        double c = a * b;
                        sw.WriteLine(item[0] + ',' + c.ToString("F2", CultureInfo.InvariantCulture));

                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);

            }
            
            //Solução do Curso
            /*Console.WriteLine("Enter full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);
                
                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            */

            Console.ReadKey();
        }
    }
}
