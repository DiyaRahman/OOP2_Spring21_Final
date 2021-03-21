using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
   {
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new SpecialSavings("DIYA", "4578728", 30, 20);
            Account a2 = new SpecialSavings("NIYA", "7578728", 700.80, 300.60);
            Account b1 = new Overdraft("SIYA", "450078728", 15, 9);
            Account b2 = new Overdraft("HIYA", "757887728", 4000.30, 2020);

            a1.ShowInfo();
            a1.Deposit(7);
            a1.Withdraw(12);
            a1.Transfer(a2, 50);
            b1.ShowInfo();
            b1.Deposit(10);
            b1.Withdraw(12);
            b1.Transfer(b2, 7);
            b1.showAllTransaction();

        }

    }
}
