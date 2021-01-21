using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class BankAccount
    {
        public int Number { get; }
        public string Owner { get; }
        public decimal Balance { get; set; }



        public BankAccount(int AccNo, string Name, decimal AccBalance)
        {
            this.Owner = Name;
            this.Number = AccNo;
            this.Balance = AccBalance;

        }
        public void MakeDeposit()
        {
            this.Balance += 20;
            Console.WriteLine(this.Balance);
        }

        public void MakeWithdrawal()
        {
            this.Balance -= 20;
            Console.WriteLine(this.Balance);
        }
    }
}
