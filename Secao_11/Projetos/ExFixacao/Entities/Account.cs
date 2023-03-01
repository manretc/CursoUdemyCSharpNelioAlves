using System;
using ExFixacao.Entities.Exceptions;
using System.Globalization;

namespace ExFixacao.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new ForbiddenOperation("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new ForbiddenOperation("Not enough balance");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return "\n**********************" +
                    "\nAccount data:" +
                    "\nNumber: " + Number +
                    "\nHolder: " + Holder +
                    "\nCurrent balance: $" + Balance.ToString("F2", CultureInfo.InvariantCulture) +
                    "\nWithdraw limit: $" + WithdrawLimit.ToString("F2", CultureInfo.InvariantCulture) +
                    "\n**********************\n";
        }

    }
}
