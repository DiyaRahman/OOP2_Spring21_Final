using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_LAB7
{
    class Savings : Account, IBasicBankingInterface
    {
        public int amount { get; set; }
        public Savings(string accName, string accNo, double balance) : base(accName, accNo, balance)
        {
            
        }
        public override void deposit(double amount)
        {
            Balance = Balance + amount;
        }
        public override void withdraw(double amount)
        {
            if (amount < Balance)
            {
                Balance = Balance - amount;
            }
        }
    }
}
