using EmployeeEmails.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace EmployeeEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>();

            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(",");
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double sal = double.Parse(Console.ReadLine());

            var emp = list.Where(p => p.Salary > sal).OrderBy(p => p.Email).Select(p => p.Email);
            Console.WriteLine($"Email of people whose salary is more than {sal}");
            foreach(string email in emp)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine();

            var sum = list.Where(p=> p.Name[0]=='M').Sum(p => p.Salary);
            Console.Write("Sum of salary of people whose name starts with 'M' = "+ sum.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
        }
    }
}
