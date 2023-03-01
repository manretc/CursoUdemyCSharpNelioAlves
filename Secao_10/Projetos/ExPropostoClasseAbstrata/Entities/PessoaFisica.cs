using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExPropostoClasseAbstrata.Entities
{
    class PessoaFisica : Contribuintes
    {
        public double HealthExpenditures { get; set; }

        public PessoaFisica(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - HealthExpenditures * 0.5;

            }
            else // if (AnualIncome >= 20000.0)
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }

        }
    }
}
