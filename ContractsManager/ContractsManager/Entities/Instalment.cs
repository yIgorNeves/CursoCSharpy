using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsManager.Entities
{
    class Instalment
    {
        public DateTime DueDate { get; set; }
        public Double Amount { get; set; }

        public Instalment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
    }
}
