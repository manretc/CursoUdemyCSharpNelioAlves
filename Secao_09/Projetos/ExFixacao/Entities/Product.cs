using System;

namespace ExFixacao.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }
        public Product(string name, double price)
        {
            Price = price;
            Name = name;
        }
    }
}
