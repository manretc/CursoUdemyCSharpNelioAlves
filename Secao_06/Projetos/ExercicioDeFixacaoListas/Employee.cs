using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioDeFixacaoListas {
    public class Employee {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void ChangeSalary(double percentage) {
            Salary *= (1 + percentage / 100);
        }

        public override string ToString() {
            return "Id: " + Id
                + ", Name: " + Name
                + ", Salaray: R$" + Salary.ToString("F2", CultureInfo.InstalledUICulture);
        }
    }
}
