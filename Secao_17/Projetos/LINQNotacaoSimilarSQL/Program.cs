using LINQNotacaoSimilarSQL.Entities;
using System.Security.Cryptography.X509Certificates;

namespace LINQNotacaoSimilarSQL {
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

            //var r1 = products.Where(x => x.Price < 900 && x.Category.Tier == 1);
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.00
                select p;
            Print("TIER 1 and PRICE < 900: ", r1);

            //var r2 = products.Where(x => x.Category.Name == "Tools").Select(p => p.Name);
            var r2 = from p in products where p.Category.Name == "Tools" select p.Name;
            Print("NAMES of PRODUCTS from TOOLS: ", r2);

            //var r3 = products.Where(x => x.Name[0] == 'C').
            //    Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new { p.Name, p.Price, CategoryName = p.Category.Name };
            Print("NAMES started with C and ANONYMOUS OBJECT: ", r3);

            //var r4 = products.Where(x => x.Category.Tier == 1).
            //    OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 = from p in products
                     where p.Category.Tier == 1
                     orderby p.Name
                     orderby p.Price
                     select p;
            Print("TIER 1 ORDER by PRICE then by NAME: ", r4);

            //var r5 = r4.Skip(2).Take(4);
            var r5 = (from p in products
                      where p.Category.Tier == 1
                      orderby p.Name
                      orderby p.Price
                      select p).Skip(2).Take(4);
            Print("TIER 1 ORDER by PRICE then by NAME SKIP 2 TAKE 4: ", r5);

            //var r16 = products.GroupBy(p => p.Category);
            var r16 = from p in products group p by p.Category;
            foreach (IGrouping<Category, Product> group in r16) {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (var item in group) {
                    Console.WriteLine(item);
                }
            }

        }
    }
}