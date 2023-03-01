using System;
using ExercicioFixacao.Entities;
using System.Globalization;
using ExercicioFixacao.Services;

namespace ExercicioFixacao {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, totalValue);

            ContractService contractService = new ContractService(installments, new PaypalService());
            contractService.ProcessContract(contract, installments);
            foreach (Installment installment in contract.Installments) {
                Console.WriteLine(installment);
            }

            
        }
    }
}