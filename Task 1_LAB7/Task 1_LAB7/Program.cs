using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_LAB7
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator C1 = new Calculator();
            int sum = C1.sum(10, 10);
            Console.WriteLine(sum);

            Calculator C2 = new Calculator();
            int sub = C2.sub(20, 10);
            Console.WriteLine(sub);

            Calculator C3 = new Calculator();
            int division = C3.division(20, 10);
            Console.WriteLine(division);

            Scientific S1 = new Scientific();
            int RESULT = S1.XtoY(3, 4);
            Console.WriteLine(RESULT);
        }
    }
}
