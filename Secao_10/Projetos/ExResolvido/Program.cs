using System;
using System.Collections.Generic;
using System.Globalization;
using ExResolvido.Entities;

namespace ExResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter the number of employess: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else list.Add(new Employee(name, hours, valuePerHour));
            }

            Console.WriteLine("\nPAYMENTS:");
            foreach (Employee employee in list)
            {
                Console.WriteLine(employee.Name + " - $" + employee.Payment().ToString("F2", CultureInfo.InstalledUICulture));
            }



        }
    }
}
