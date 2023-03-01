using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExPropostoClasseAbstrata.Entities
{
    abstract class Contribuintes
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Contribuintes(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
