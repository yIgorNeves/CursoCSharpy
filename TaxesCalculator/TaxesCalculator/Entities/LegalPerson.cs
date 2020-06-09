using System;
using System.Collections.Generic;
using System.Text;

namespace TaxesCalculator.Entities
{
    class LegalPerson : Person
    {
        public int Employees { get; set; }

        public LegalPerson(string name, double anualIncome, int employees) : base(name, anualIncome)
        {
            Employees = employees;
        }

        public override double Tax()
        {
            double ToPay = 0.0;

            if (Employees < 10)
            {
                ToPay = AnualIncome * 0.16;
            }
            else
            {
                ToPay = AnualIncome * 0.14;
            }

            return ToPay;
        }
    }
}
