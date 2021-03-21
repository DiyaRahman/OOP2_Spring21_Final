using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    class Overdraft:Account
    {
        public int Limit { get; set; }
        public Overdraft() { }
        public Overdraft(string accName, string accNo, double balance, double Openingbalance) : base(accName, accNo, balance)
        {
            Limit = Limit;
        }
        public override void Deposit(double amount)
        {
            Balance = Balance + amount;
            Console.WriteLine("account credited " + amount + " and updated is "  +Balance);
            Transaction transaction = new Transaction(this, this, amount, "Deposit");
            base.addTransaction(transaction);
        }
        public override void Withdraw(double amount)
        {
            if (amount <= (Balance + Limit))
            {
                Balance = Balance - amount;
                //Console.WriteLine("account debited {o} and updated balance {1}", amount, Balance);
                Transaction transaction = new Transaction(this, this, amount, "Withdraw");
                base.addTransaction(transaction);
            }
            else
            {
                Console.WriteLine("Insufficient Balance:" + (Balance + Limit));
            }
        }
        public override void Transfer(Account a, double amount)
        {
            if (amount <= (Balance + Limit))
            {
                Balance = Balance - amount;
                a.Balance += amount;
                //Console.WriteLine("account debited {o} ,updated balance {1} and credited account: {2} {3}", amount, a.AccName, a.AccNo, Balance);
                Transaction transaction = new Transaction(this, a, amount, "Transfer");
                base.addTransaction(transaction);
            }
            else
            {
                Console.WriteLine("Insufficient Balance:" + (Balance + Limit));
            }
        }
        

    }
}
