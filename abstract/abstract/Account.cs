using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    abstract class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; set; }
        public double Balance { get; set; }
        Transaction[] transactions;
        public int totalNoOfTransaction { get; set; }

        public Account(){ }
        public Account(string accName, string accNo, double balance) {

            AccName = accName;
            AccNo = accNo;
            Balance = balance;
            transactions = new Transaction[50];
        }

        public void showAllTransaction()
        {
            for(int i=0; i<totalNoOfTransaction; i++)
            {
                transactions[i].showAllTransaction();
            }
        }

        public void addTransaction ( params Transaction [] Transactions)
        {
            foreach(Transaction transaction in Transactions)
            {
                this.transactions[totalNoOfTransaction++] = transaction;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + AccName);
            Console.WriteLine("Acc No: " + AccNo);
        }

        public abstract void Deposit(double amount);
         public abstract void Withdraw(double amount);

         public abstract void Transfer(Account a, double amount);
    }
}
