using ExercicioFixacao.Entities;
using System.Globalization;
using System.Linq;

namespace ExercicioFixacao {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter full file path: " + @"C:\D2Ponto\GoogleDrive\Udemy\C# Completo\Secao_17\Projetos\ExercicioFixacao\Files\Input.csv");
            string path = @"C:\D2Ponto\GoogleDrive\Udemy\C# Completo\Secao_17\Projetos\ExercicioFixacao\Files\Input.csv"; // Console.ReadLine();
            Console.Write("Enter the salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            List<Employees> list = new List<Employees>();
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double earnings = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Employees(name, email, earnings));
                    }
                }

                var emails = list.Where(p => p.Salary > salary).
                    OrderBy(p => p.Email).Select(p => p.Email);
                Console.WriteLine("Email of people whose salary is more than " + salary + ":");
                foreach (var item in emails) {
                    Console.WriteLine(item);
                }

                var sum = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}