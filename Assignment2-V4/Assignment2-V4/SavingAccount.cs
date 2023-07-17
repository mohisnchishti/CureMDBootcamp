using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_V4
{
    public class SavingAccount:BankAccount,ITransaction
    {
        public SavingAccount(string accountHolderName, double Accountbalance, double accountNumber)
            : base(accountHolderName, Accountbalance, accountNumber)
        { }

        public override void InterestRate()
        {
            double interest =AccountBalance*0.11;
            AccountBalance = AccountBalance + interest;
        }
        public override void Deposit(double amount)
        {
            
            // Console.WriteLine("");
            AccountBalance = AccountBalance + amount;
            Console.WriteLine(amount + " has been deposited to account and New Balance is " + AccountBalance);
        }
        public override void withdraw(double amount)
        {
            //double WithdrawAmount = 0;
            if (AccountBalance > amount)
            {
                //double amount = 0;
                // Console.WriteLine("");
                AccountBalance = AccountBalance - amount;
                Console.WriteLine(amount + " has been deducted from your account and New Balance is " + AccountBalance);
            }
            else
            {
                Console.WriteLine("Your Balance is in sufficient");

            }
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine("Account Type: Savings Account");
            Console.WriteLine("Account Number "+ AccountNumber);
            Console.WriteLine("Account Holder "+ AccountHolderName);
            Console.WriteLine("AccountBalance "+ AccountBalance);
            Console.WriteLine($"Interest Rate"+AccountBalance);
        }
        public void PrintTransaction()
        {
            Console.WriteLine("Savings Account Transaction");
            Console.WriteLine("Account Number"+ AccountNumber);
           Console.WriteLine("Amount"+ AccountBalance);
        }
        public void ExecuteTransaction(double amount)
        {
            Deposit(amount);
        }
    }
}
