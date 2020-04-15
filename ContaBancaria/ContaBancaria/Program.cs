using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;

            Console.Write("Entre com o numero da conta: ");
            int acountNumber =  int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string name = Console.ReadLine();

            Console.Write("Havera deposito inicial (s/n)?");
            string dep = Console.ReadLine();

            

            if (dep == "s")
            {
                Console.Write("Entre com o valor inicial do deposito: ");
                double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(name, acountNumber, deposit);               
            }
            else
            {
                c = new Conta(name, acountNumber);
            }
           
            Console.WriteLine("Dados da conta:");            
            Console.WriteLine(c);

            Console.WriteLine();

            Console.Write("Entre com um valor de deposito: ");
            c.MakeDeposit(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);

            Console.WriteLine();

            Console.Write("Entre com um valor de saque: ");
            c.MakeWitdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) + 5);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);
        }
    }
}
