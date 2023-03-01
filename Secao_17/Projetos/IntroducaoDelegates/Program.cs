using IntroducaoDelegates.Services;
using IntroducaoDelegates.Entities;
using System.Linq;

namespace IntroducaoDelegates {
    internal class Program {
        // delegate double BinaryNumericOperation(double n1, double n2);
        //delegate void BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args) {
            double a = 10;
            double b = 12;
            //Introdução a Delegate
            // BinaryNumericOperation op = CalculationService.Sum;
            // BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            // double result = op(a, b);
            // double result = op.Invoke(a, b);
            //Console.WriteLine(result);

            //MulticastDelegate Delegate
            //BinaryNumericOperation op = CalculationService.ShowSum;
            //op += CalculationService.ShowMax;

            //op(a, b);

            // Delegate Predicate
            //List<Product> list = new List<Product>();
            //list.Add(new Product("Tv", 900.00));
            //list.Add(new Product("Mouse", 50.00));
            //list.Add(new Product("Tablet", 350.50));
            //list.Add(new Product("HD Case", 80.90));
            //foreach (var item in list) {
            //    Console.WriteLine(item);
            //}

            //list.RemoveAll(ProductTest);//p => p.Price >= 100);
            //foreach (var item in list) {
            //    Console.WriteLine(item);
            //}

            //Delegate Action
            //List<Product> list = new List<Product>();
            //list.Add(new Product("Tv", 900.00));
            //list.Add(new Product("Mouse", 50.00));
            //list.Add(new Product("Tablet", 350.50));
            //list.Add(new Product("HD Case", 80.90));

            //Action<Product> act = p => { p.Price += p.Price * 0.1};

            //list.ForEach(act);
            //foreach (var item in list) {
            //    Console.WriteLine(item);
            //}

            //Delegate Func
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Func<Product, string> func = p => p.Name.ToUpper();//NameUpper;

            List<string> result = list.Select(func).ToList();
            foreach (var item in result) {
                Console.WriteLine(item);
            }

        }

        static string NameUpper(Product p) {
            return p.Name.ToUpper();
        }

        static void UpdatePrice(Product p) {
            p.Price += p.Price * 0.1;
        }
        public static bool ProductTest(Product p) {
            return p.Price >= 100;
        }

    }
}