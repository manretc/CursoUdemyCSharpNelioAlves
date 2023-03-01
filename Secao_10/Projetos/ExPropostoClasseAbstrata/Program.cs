using System;
using System.Collections.Generic;
using System.Globalization;
using ExPropostoClasseAbstrata.Entities;

namespace ExPropostoClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuintes> list = new List<Contribuintes>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Tax payer #{i} data:\n"
                    + "Individual or company(i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new PessoaFisica(name, anualIncome, healthExpenditures));
                }
                if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine("TAXES PAID:");
            double totaTaxes = 0.0;
            foreach (Contribuintes item in list)
            {
                totaTaxes += item.Tax();
                Console.WriteLine(item.Name + ": $" + item.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine("TOTAL TAXES: $"+ totaTaxes.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
