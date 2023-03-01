﻿using LINQcomLambda.Entities;
using System.Security.Cryptography.X509Certificates;

namespace LINQcomLambda {
    internal class Program {
        static void Main(string[] args) {

            static void Print<T>(string message, IEnumerable<T> collection) {
                Console.WriteLine(message);
                foreach (var item in collection) {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }

            Category c1 = new Category() { ID = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { ID = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { ID = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = products.Where(x => x.Price < 900 && x.Category.Tier == 1);
            Print("TIER 1 and PRICE < 900: ", r1);

            var r2 = products.Where(x => x.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES of PRODUCTS from TOOLS: ", r2);

            var r3 = products.Where(x => x.Name[0] == 'C').
                Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("NAMES started with C and ANONYMOUS OBJECT: ", r3);

            var r4 = products.Where(x => x.Category.Tier == 1).
                OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER by PRICE then by NAME: ", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER by PRICE then by NAME SKIP 2 TAKE 4: ", r5);

            var r6 = products.First();
            Console.WriteLine("First test1: " + r6);

            var r7 = products.Where(p => p.Price > 3000).FirstOrDefault();
            Console.WriteLine("First or Default test2: " + r7);

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or Default test1: " + r8);

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or Default test2: " + r9 + "\n");

            var r10 = products.Max(p => p.Price);
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Max Price: " + r10 + "\nMin price: " + r11);

            var r12 = products.Where(p => p.Category.ID == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);
            var r13 = products.Where(p => p.Category.ID == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);
            var r14 = products.Where(p => p.Category.ID == 5).
                Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Average prices: " + r14);

            var r15 = products.Where(p => p.Category.ID == 1).
                Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 Aggregate sum: " + r15 + "\n");

            var r16 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> group in r16) {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (var item in group) {
                    Console.WriteLine(item);
                }
            }

        }
    }
}