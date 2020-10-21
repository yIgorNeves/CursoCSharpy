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

            var emp = list.Where(obj => obj.Salary > sal).OrderBy(obj => obj.Email).Select(obj => obj.Email);
            Console.WriteLine($"Email of people whose salary is more than {sal.ToString("F2", CultureInfo.InvariantCulture)}:");
            foreach(string email in emp)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine();

            var sum = list.Where(obj => obj.Name[0]=='M').Sum(obj => obj.Salary);
            Console.Write("Sum of salary of people whose name starts with 'M' = "+ sum.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
        }
    }
}
