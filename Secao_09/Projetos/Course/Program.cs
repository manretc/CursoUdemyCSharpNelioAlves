using System;
using Course.Entities.Enums;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
            OrderStatus os2;
            Enum.TryParse("Delivered", out os2);

            Console.WriteLine(os);


        }
    }
}
