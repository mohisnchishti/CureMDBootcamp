using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_V4
{
    class Bank
    {
        private Dictionary<double, BankAccount> accounts;

        public Bank()
        {
            accounts = new Dictionary<double, BankAccount>();
        }
        public void AddAccount(BankAccount account)
        {
            accounts.Add(account.AccountNumber, account);
            Console.WriteLine("Account added successfully.");
        }

        public void DepositToAccount(double accountNumber, double amount)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                accounts[accountNumber].Deposit(amount);
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        public void WithdrawFromAccount(double accountNumber, double amount)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                accounts[accountNumber].withdraw(amount);
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        public void PrintTransactionHistory(double accountNumber)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                BankAccount account = accounts[accountNumber];
                Console.WriteLine("Transaction History for Account Number "+ accountNumber);
                foreach (Transaction transaction in account.transactions)
                {
                    Console.WriteLine($"{transaction.Date} - {transaction.Type}: {transaction.Amount:C}");
                }
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }
    }
}
