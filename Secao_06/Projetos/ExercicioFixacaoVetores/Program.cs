using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoVetores {
    class Program {
        static void Main(string[] args) {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Quarto[] quartos = new Quarto[10];

            for (int i = 1; i <= n; i++) {
                Console.Write("Aluguel #" + i);
                Console.Write("\nNome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numquarto = int.Parse(Console.ReadLine());
                quartos[numquarto] = new Quarto(nome, email, numquarto);
            }
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < quartos.Length; i++) {
                if (quartos[i] != null) Console.WriteLine(quartos[i]);
            }

        }
    }
}
