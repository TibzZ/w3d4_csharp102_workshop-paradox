using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(12345,"James",100);
            Console.WriteLine($"{account.Owner} has £{account.Balance} with account number of {account.Number}");
            account.MakeDeposit();
            account.MakeWithdrawal();
        }
    }
}
