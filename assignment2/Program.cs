using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    using System;

    namespace Assignment_2
    {
        public abstract class BankAccount
        {
            public int Account_number { get; set; }
            public string Accountholder_name { get; set; }
            public double Account_balance { get; set; }

            public BankAccount(int account_number, string accountholder_name, double account_balance)
            {
                Account_number = account_number;
                Accountholder_name = accountholder_name;
                Account_balance = account_balance;
            }

            public virtual void Deposit()
            {
                Console.WriteLine("Please enter the amount you want to deposit:");
                double amount = double.Parse(Console.ReadLine());
                Account_balance += amount;
                Console.WriteLine($"The amount after deposit is {Account_balance}");
            }

            public virtual void Withdraw()
            {
                Console.WriteLine("Please enter the amount you want to withdraw:");
                double withdrawal_amount = double.Parse(Console.ReadLine());
                if (withdrawal_amount > Account_balance)
                {
                    Console.WriteLine($"{withdrawal_amount} is insufficient");
                }
                else
                {
                    Account_balance -= withdrawal_amount;
                    Console.WriteLine($"The amount after withdrawal is {Account_balance}");
                }
            }

            public abstract void DisplayAccountinfo();
        }

        public class SavingAccount : BankAccount
        {
            public SavingAccount(int account_number, string accountholder_name) : base(account_number, accountholder_name, 12345)
            {
            }

            public override void Deposit()
            {
                double interest = 0.11;
                Console.WriteLine("Please enter the amount you want to deposit:");
                double amount = double.Parse(Console.ReadLine());

                double c = amount * interest;
                Account_balance += c;

                Console.WriteLine($"The amount after interest is {Account_balance}");
            }

            public override void DisplayAccountinfo()
            {
                Console.WriteLine("Account number: " + Account_number);
                Console.WriteLine("Account holder name: " + Accountholder_name);
                Console.WriteLine("Current balance: " + Account_balance);
            }
        }

        public class CheckingAccount : BankAccount
        {
            public CheckingAccount(int account_number, string accountholder_name) : base(account_number, accountholder_name, 5000)
            {
            }

            public override void Withdraw()
            {
                Console.WriteLine("Please enter the amount you want to withdraw:");
                double withdrawal_amount = double.Parse(Console.ReadLine());
                if (withdrawal_amount > Account_balance)
                {
                    Console.WriteLine($"{withdrawal_amount} is insufficient");
                }
                else
                {
                    Account_balance -= withdrawal_amount;
                    Console.WriteLine($"The amount after withdrawal is {Account_balance}");
                }

            }

            public override void DisplayAccountinfo()
            {
                Console.WriteLine("Account number: " + Account_number);
                Console.WriteLine("Account holder name: " + Accountholder_name);
                Console.WriteLine("Current balance: " + Account_balance);
            }
        }
        public class Bank
        {
                //public Bank(int account_number, string accountholder_name) : base(account_number, accountholder_name, 5000)
                //{
                //}
                public List<BankAccount> BankAccounts { get; set; }

                public  Bank()
                {
                    BankAccounts = new List<BankAccount>();
                }
                public void AddAccount(BankAccount bankAccount)
                {
                    BankAccounts.Add(bankAccount);
                    Console.WriteLine("");
                }
                public void DeposittoAccount(BankAccount account,int amount)
                {
                    account.Account_balance += amount;
                Console.WriteLine($"The amount after deposit is {account.Account_balance}");
            }

        }
        

        class Program
        {
            static void Main(string[] args)
            {
                SavingAccount saving_account = new SavingAccount(321456, "Haris");
                saving_account.Deposit();
                saving_account.DisplayAccountinfo();
                CheckingAccount checkingaccount = new CheckingAccount(12345, "usama");
                checkingaccount.Withdraw();
                checkingaccount.DisplayAccountinfo();
                Bank Mehzupur = new Bank();
                Mehzupur.AddAccount(saving_account);
                Mehzupur.AddAccount(checkingaccount);
                Mehzupur.DeposittoAccount(saving_account, 900000000);
                Console.ReadKey();
            }
        }
    }
}
