using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_2_LAB7
{
    class Program
    {
        static void Main(string[] args)
        {
            Account A1 = new Current("Diya", "183848", 40000);
            A1.ShowInfo();
            A1.deposit(5000);
            A1.ShowInfo();
            A1.withdraw(1000);
            A1.ShowInfo();
            Account A2 = new Current("Riya", "180738", 70000);
            A2.ShowInfo();
            A2.deposit(7000);
            A2.ShowInfo();
            A2.withdraw(2000);
            A2.ShowInfo();
        }
    }
}
