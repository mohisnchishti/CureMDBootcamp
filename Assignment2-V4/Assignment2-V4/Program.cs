using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            SavingAccount savingsAccount = new SavingAccount("Haris",1000, 123);
            bank.AddAccount(savingsAccount);

            CheckingAccount checkingAccount = new CheckingAccount("Usama",500, 456);
            bank.AddAccount(checkingAccount);

            LoanAccount loanAccount = new LoanAccount("Awais", 2000,  789);
            bank.AddAccount(loanAccount);

            bank.DepositToAccount((double)123, 5000);
            bank.WithdrawFromAccount(123, 2000);

            bank.DepositToAccount(456, 2000);
            bank.WithdrawFromAccount(456, 700);

            bank.DepositToAccount(789, 10000);
            bank.WithdrawFromAccount(789, 3000);

            bank.PrintTransactionHistory(123);
            bank.PrintTransactionHistory(456);
            bank.PrintTransactionHistory(789);

            Console.ReadLine();
        }
    }
    }

