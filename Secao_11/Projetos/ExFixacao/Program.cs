using System;
using ExFixacao.Entities;
using ExFixacao.Entities.Exceptions;
using System.Globalization;

namespace ExFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n < 4)
            {

                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account acc = new Account(number, holder, balance, withdrawLimit);

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                try
                {
                    acc.Withdraw(amount);
                    Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));

                }
                catch (ForbiddenOperation e)
                {
                    Console.WriteLine("Withdraw error: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected error: " + e.Message);
                }
                finally
                {
                    Console.WriteLine(acc.ToString());
                }


                n++;
            }

        }
    }
}
