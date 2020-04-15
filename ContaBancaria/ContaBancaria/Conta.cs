using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        public string Name { get; set; }
        public int AcountNumber { get; private set; }
        public double Balance { get; set; }

        public Conta(string name, int acountNumber)
        {
            Name = name;
            AcountNumber = acountNumber;
        }

        public Conta(string name, int acountNumber, double deposit) : this(name, acountNumber)
        {
            MakeDeposit(deposit);
        }

        public void MakeDeposit(double deposit)
        {
            Balance += deposit;
        }

        public void MakeWitdraw(double witdraw)
        {
            Balance -= witdraw;
        }

        public override string ToString()
        {
            return "Conta "
                + AcountNumber
                + ", Titular: "
                + Name
                + ", Saldo: R$"
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
