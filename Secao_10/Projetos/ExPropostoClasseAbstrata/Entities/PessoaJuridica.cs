using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExPropostoClasseAbstrata.Entities
{
    class PessoaJuridica : Contribuintes
    {
        public int NumberOfEmployees { get; set; }

        public PessoaJuridica(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }

    }
}
