using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public  class BankAccount
    {
        int Account_number;
        string Accountholder_name;
        double Account_balance;

        public BankAccount(int account_number, string accountholder_name, int account_balance)
        {
            Account_number = account_number;
            Accountholder_name = accountholder_name;
            Account_balance = account_balance;

        }
        public virtual void Deposit()
        {
            Console.WriteLine("Please enter the amount you wanna deposit");
            int amount = int.Parse(Console.ReadLine());
            Account_balance += amount;
            Console.WriteLine($"the amount after deposit is {Account_balance}");

        }
        public virtual void Withdraw()
        {
            Console.WriteLine("Please enter the amount you wanna Withdraw");
            int withdrawal_amount = int.Parse(Console.ReadLine());
            Account_balance -= withdrawal_amount;
            Console.WriteLine("The amount after the withdrawal is " + Account_balance);

        }
        public void DisplayAccountinfo()
        {
            Console.WriteLine("The account_number is " + Account_number);
            Console.WriteLine("The name is " + Accountholder_name);
            Console.WriteLine("The Current balance is " + Account_balance);

        }

        public class SavingAccount : BankAccount
        {
           
            public SavingAccount(int account_number, string accountholder_name) : base(account_number, accountholder_name, 12345)
            { 
            }

            public override void Deposit()
            {
                double interest = 0.11;
                double c;
                Console.WriteLine("Please enter the amount you wanna deposit");
                double amount = int.Parse(Console.ReadLine());

                //double AccountBalance;
                //double amount;
                //double b;
                //b = amount * interest;
                c = amount * interest;
                Account_balance += c;
                
                Console.WriteLine("The amount after the interest is "+Account_balance); 


            }




        }
        public class CheckingAccount:BankAccount
        {
            public CheckingAccount(int account_number, string accountholder_name) : base(account_number, accountholder_name, 5000)
            { }

            public override void Withdraw()
            {
                Console.WriteLine("Please enter the amount you wanna Withdraw");
                int withdrawal_amount = int.Parse(Console.ReadLine());
                //Account_balance = Account_balance - withdrawal_amount;
                if (withdrawal_amount > Account_balance)
                {
                    Console.WriteLine(withdrawal_amount + " is un sufficient");

                }
                else 
                {

                    Account_balance = Account_balance - withdrawal_amount;
                    Console.WriteLine(Account_balance + "the amount after withrawal");
                }
                
            }
        }




        class Program
        {
            static void Main(string[] args)
            {
                BankAccount Usama = new BankAccount(214612, "Chishti", 500);
                //Console.WriteLine(Usama.Account_number);
                //Console.WriteLine(Usama.Accountholder_name);
                Console.WriteLine(Usama.Account_balance);
                Usama.Deposit();
                Console.WriteLine(Usama.Account_balance);

                BankAccount yazdani = new BankAccount(321456, "Haris", 2000);
                Console.WriteLine(yazdani.Account_balance);
                yazdani.Withdraw();
                Console.WriteLine(yazdani.Account_balance);
                Usama.DisplayAccountinfo();
                SavingAccount saving_account = new SavingAccount(321456,"Haris");
                saving_account.Deposit();
                CheckingAccount checkingaccount = new CheckingAccount(1234, "john");
                checkingaccount.Withdraw();


                Console.ReadKey();

            }
        }
    }
   
}
