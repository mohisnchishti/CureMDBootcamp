using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_V4
{
    class CheckingAccount:BankAccount , ITransaction
    {
        public CheckingAccount(string accountHolderName, double Accountbalance, double accountNumber)
            : base( accountHolderName, Accountbalance, accountNumber)
        {
        }

        public override void InterestRate()
        {
            double interest = AccountBalance*.15;
            AccountBalance = AccountBalance + interest;
        }
        //public override void Deposit()
        //{
        //    double amount = 0;
        //    // Console.WriteLine("");
        //    AccountBalance = AccountBalance + amount;
        //    Console.WriteLine(amount + " has been deposited to account and New Balance is " + AccountBalance);
        //}
        //public virtual void withdraw()
        //{
        //    double WithdrawAmount = 0;
        //    if (AccountBalance > WithdrawAmount)
        //    {
        //        double amount = 0;
        //        // Console.WriteLine("");
        //        AccountBalance = AccountBalance - amount;
        //        Console.WriteLine(amount + " has been deducted from your account and New Balance is " + AccountBalance);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Your Balance is in sufficient");

        //    }
        //}

        public override void DisplayAccountInfo()
        {
            Console.WriteLine("Account Type: Checking  Account");
            Console.WriteLine("Account Number " + AccountNumber);
            Console.WriteLine("Account Holder " + AccountHolderName);
            Console.WriteLine("AccountBalance " + AccountBalance);
            Console.WriteLine("Interest Rate"+AccountBalance);
        }
        public void PrintTransaction()
        {
            Console.WriteLine("Checking Account Transaction");
            Console.WriteLine("Account Number"+ AccountNumber);
            Console.WriteLine("Amount"+AccountBalance);
        }
        public void ExecuteTransaction(double amount)
        {
           Deposit(amount);
        }
    }
}
