﻿
namespace ExercicioFixacao.Entities {
    internal class Employees {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employees(string name, string email, double salary) {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
