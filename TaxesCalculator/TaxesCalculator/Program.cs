using System;
using System.Collections.Generic;
using System.Globalization;
using TaxesCalculator.Entities;

namespace TaxesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                if(ch == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anual = double.Parse(Console.ReadLine());
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine());

                    list.Add(new PhysicalPerson(name, anual, health));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anual = double.Parse(Console.ReadLine());
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    list.Add(new LegalPerson(name, anual, employees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            double sum = 0;
            foreach (Person p in list)
            {
                Console.WriteLine($"{p.Name}: $ {p.Tax()}", ("F2", CultureInfo.InvariantCulture));
                sum += p.Tax();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sum}");
        }
    }
}
