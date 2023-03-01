using System;
//using Extension_Methods.Extensions;

namespace Extension_Methods {
    internal class Program {
        static void Main(string[] args) {
            DateTime dt = new DateTime(2023, 1, 30, 10, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            String s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
       

        }
    }
}