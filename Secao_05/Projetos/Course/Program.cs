using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00, 10);
            p.Nome = "T";
            Console.WriteLine(p.Nome + " " + p.Preco.ToString("F2", CultureInfo.InvariantCulture) + " " + p.Quantidade);

        }
    }
}
