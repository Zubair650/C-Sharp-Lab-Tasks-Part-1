using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Account
{
    class Account
    {
        private string accName;
        private string acid;
        private int balance;
        private int amount;

        Account()
        {
            Console.WriteLine("Constructor called");
        }
        void Deposit(int amount)
        {
            Console.WriteLine("The depositted money: " + amount);

        }
        void Withdraw(int amount)
        {
            Console.WriteLine("The Withdrawal money: " + amount);
        }
        static void Main(string [] args)
        {
            Account acc = new Account();
            acc.Deposit(15000);
            acc.Withdraw(20000);
        }
    }
}
