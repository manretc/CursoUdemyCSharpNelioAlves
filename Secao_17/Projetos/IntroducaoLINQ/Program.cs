using System.Runtime.InteropServices;

namespace IntroducaoLINQ {
    internal class Program {
        static void Main(string[] args) {
            //Introdução a LINQ
            //Specify the data source
            int[] numbers = { 2, 3, 4, 5 };
            //Define the query expression
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);
            //Execute the query
            foreach (var item in result) {
                Console.WriteLine(item);
            }




        }
    }
}