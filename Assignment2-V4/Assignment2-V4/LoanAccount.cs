using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_V4
{
    class LoanAccount:BankAccount,ITransaction
    {
        public LoanAccount(string accountHolderName, double Accountbalance, double accountNumber)
                   : base(accountHolderName, Accountbalance, accountNumber)
        {
        }
        public override void DisplayAccountInfo()
        {
            Console.WriteLine("Account Type: Savings Account");
            Console.WriteLine("Account Number " + AccountNumber);
            Console.WriteLine("Account Holder " + AccountHolderName);
            Console.WriteLine("AccountBalance " + AccountBalance);
            Console.WriteLine("Interest Rate"+ AccountBalance);
        }
        public void ExecuteTransaction(double amount)
        {
            Deposit(amount);
        }
        public override void InterestRate()
        {
            double interest = AccountBalance * .17;
            AccountBalance = AccountBalance + interest;
        }

        public void PrintTransaction()
        {
            Console.WriteLine("Loan Account Transaction");
            Console.WriteLine("Account Number"+AccountNumber);
           Console.WriteLine("Amount "+AccountBalance);
        }
       
        
            
    }
    }

