using System;
using System.Globalization;
using WorkerContracts.Entities.Enums;
using WorkerContracts.Entities;

namespace WorkerContracts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior)");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Enter base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Depatarment dept = new Depatarment(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker?");
            int x = int.Parse(Console.ReadLine());

            for(int i=0; i < x; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data: ");
                Console.Write("Date(DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, value, hours);
                worker.AddContracts(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income(MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Depatarment: " + worker.Depatarment.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));
                
                
                
        }
    }
}
