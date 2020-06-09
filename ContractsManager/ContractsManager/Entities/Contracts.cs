using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsManager.Entities
{
    class Contracts
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Instalment> Instalment { get; set; }

        public Contracts(int number, DateTime date, double totalValue, List<Instalment> instalments)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Instalment = new List<Instalment>();
        }
    }
}
