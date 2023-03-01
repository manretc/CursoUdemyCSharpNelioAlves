using ExercicioResolvido.Entities;
using System.Globalization;

namespace ExercicioResolvido {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter full file path: " + @"C:\D2Ponto\GoogleDrive\Udemy\C# Completo\Secao_17\Projetos\ExercicioResolvido\Files\Input.csv");
            string path = @"C:\D2Ponto\GoogleDrive\Udemy\C# Completo\Secao_17\Projetos\ExercicioResolvido\Files\Input.csv"; // Console.ReadLine();

            List<Product> list = new List<Product>();
            using (StreamReader sr = File.OpenText(path)) {
                while (!sr.EndOfStream) {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).
                OrderByDescending(p => p.Name).Select(p => p.Name);

            foreach (var item in names) {
                Console.WriteLine(item);
            }
        }
    }
}