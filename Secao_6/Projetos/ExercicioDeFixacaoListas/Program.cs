using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioDeFixacaoListas {
    class Program {
        static void Main(string[] args) {

            List<Employee> employeesList = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            int id;
            for (int i = 1; i <= n; i++) {

                Console.Write("Employee #" + i + ": ");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
                bool idcheck = false;
                if (i > 1) {
                    foreach (Employee employee in employeesList) {
                        if (employee.Id == id) idcheck = true;
                    }
                }
                if (idcheck) {
                    Console.WriteLine("\nThis Id has already been used.\nEmployee " + name + " will note be registered.\n");
                    idcheck = false;
                }
                else {
                    employeesList.Add(new Employee(id, name, salary));
                    idcheck = false;
                }

            }

            Console.WriteLine("\nUpdated list of employees:");
            foreach (Employee employee in employeesList) {
                Console.WriteLine(employee);
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            bool checkerid = false;
            foreach (Employee employee in employeesList) {
                if (id == employee.Id) {
                    employee.ChangeSalary(percentage);
                    checkerid = true;
                }
            }
            if (!checkerid) Console.WriteLine("This id does not exist!\n");

            Console.WriteLine("\nUpdated list of employees:");
            foreach (Employee employee in employeesList) {
                Console.WriteLine(employee);
            }


        }


    }
}
