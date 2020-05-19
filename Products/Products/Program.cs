using Products.Entities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, Used, Imported (c/u/i): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if(ch == 'i')
                {
                    Console.Write("Customs Fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, fee));
                }
                else if (ch == 'u')
                {
                    Console.Write("Manufactured Date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProducts(name, price, date));
                }
                else
                {
                    list.Add(new Product(name, price));
                }        

            }

            Console.WriteLine();
            Console.WriteLine("Price Tags:");

            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
