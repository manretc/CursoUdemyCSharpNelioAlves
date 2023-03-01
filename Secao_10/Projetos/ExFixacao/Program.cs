using System;
using System.Globalization;
using System.Collections.Generic;
using ExFixacao.Entities;


namespace ExFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> Product = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (c == 'c')
                {
                    Product.Add(new Product(name, price));
                }
                else if (c == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY):");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    Product.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (c == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    Product.Add(new ImportedProduct(name, price, customsFee));
                }
                else Console.WriteLine("The product type is invalid!");
            }
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in Product)
            {
                Console.WriteLine(product.PriceTag());
            }

        }
    }
}
