using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_LAB7
{
    abstract class Account : IBasicBankingInterface
    {
        public string AccName { get; set; }
        public string AccNo { get; set; }
        public double Balance { get; set; }
        public Account() { }
        public Account(string accName, string accNo, double balance)
        {

            AccName = accName;
            AccNo = accNo;
            Balance = balance;
           
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + AccName);
            Console.WriteLine("Acc No: " + AccNo);
            Console.WriteLine("Balance: " + Balance);
        }

        public abstract void deposit(double amount);
        public abstract void withdraw(double amount);

       
    }
}