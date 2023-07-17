using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_V4
{
    public abstract class  BankAccount
    {
        public double AccountNumber {get;set;}
        public double AccountBalance{ get; set; }
        public string AccountHolderName{ get; set; }
        public List<Transaction> transactions { get; set; }

        public BankAccount(string accountHolderName, double Accountbalance, double accountNumber)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            AccountBalance = Accountbalance;
            transactions = new List<Transaction>();
        }

        public abstract void DisplayAccountInfo();
        public virtual void Deposit(double amount)
        {
            
           // Console.WriteLine("");
            AccountBalance = AccountBalance + amount;
            Console.WriteLine(amount+" has been deposited to account and New Balance is "+AccountBalance);
        }

        public virtual void withdraw(double amount)
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
        public abstract void InterestRate();
        protected void AddTransaction(string type, decimal amount)
        {
            Transaction transaction = new Transaction(DateTime.Now, type, amount);
            transactions.Add(transaction);
        }




    }
}
