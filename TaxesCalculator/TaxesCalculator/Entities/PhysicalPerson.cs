using System;
using System.Collections.Generic;
using System.Text;

namespace TaxesCalculator.Entities
{
    class PhysicalPerson : Person
    {
        public double Health { get; set; }

        public PhysicalPerson(string name, double anualIncome, double health) : base(name, anualIncome)
        {
            Health = health;
        }

        public override double Tax()
        {
            double ToPay = 0;
            if (AnualIncome < 20000)
            {
                ToPay = (AnualIncome * 0.15) - (Health * 0.5);
            }
            else
            {
                ToPay = (AnualIncome * 0.25) - (Health * 0.5);
            }
            return ToPay;
        }
    }
}
