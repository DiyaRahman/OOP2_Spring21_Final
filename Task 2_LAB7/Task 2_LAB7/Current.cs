using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_2_LAB7
{
    class Current : Account, IBasicBankingInterface
    {
        public double amount { get; set; }
        public Current(string accName, string accNo, double balance) : base(accName, accNo, balance)
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
