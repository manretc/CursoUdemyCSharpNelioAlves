﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100, 500);

            Console.WriteLine(account.Balance);
            //account.Balance = 200;*/


            /*
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //Upcasting
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingAccount(1004, "Bob", 0.0, 0.01);

            //Downcasting
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if (acc3 is SavingAccount)
            {
                SavingAccount acc5 = (SavingAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }*/

            /*
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingAccount(1002, "Ana", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            */

            List<Account> list = new List<Account>();

            list.Add(new SavingAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Ana", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }
            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10);
                Console.WriteLine("Update balance for account: " +
                    acc.Number + ": " +
                    acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
