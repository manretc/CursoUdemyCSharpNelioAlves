using System;
using ExFixacao.Entities.Enums;
using ExFixacao.Entities;
using System.Globalization;

namespace ExFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Client client = new Client();
            Console.Write("Name: ");
            client.Name = Console.ReadLine();
            Console.Write("Email: ");
            client.Email = Console.ReadLine();
            Console.Write("Birth: ");
            client.BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

            Order order = new Order(status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string name = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(name, price);
                OrderItem item = new OrderItem(quantity, price, product);
                order.AddItem(item);
            }
            Console.WriteLine(order.ToString());
        }
    }
}
