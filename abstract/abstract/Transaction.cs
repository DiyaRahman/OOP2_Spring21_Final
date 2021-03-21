using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    class Transaction
    {
        public Account sender { get; set; }
        public Account receiver { get; set; }

        public double amount { get; set; }
        public string additionalInfo { get; set; }

        public Transaction() { }
        public Transaction(Account sender, Account receiver, double amount, string additionalInfo)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.amount = amount;
            this.additionalInfo = additionalInfo;
        }

        public void showAllTransaction()
        {
            Console.WriteLine("Additional info: " + additionalInfo);
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Sender: " + sender.AccName);
            Console.WriteLine("Receiver: " + receiver.AccName);
        }
    }
}
