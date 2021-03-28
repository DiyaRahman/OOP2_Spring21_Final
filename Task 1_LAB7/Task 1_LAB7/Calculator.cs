using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_LAB7
{
    class Calculator:BasicCalculatorInterface
    {
        public int FirstNo { get; set; }
        public int SecondNo { get; set; }

        public Calculator() { }

        public Calculator (int firstno, int secondno)
        {
            FirstNo = firstno;
            SecondNo = secondno;
        }
        public int sum(int x, int y)
        {
            return x + y;
        }
        public int sub(int x, int y)
        {
            return x - y;
        }
        public int multiplication(int x, int y)
        {
            return x * y;
        }
        public int division(int x, int y)
        {
            return x / y;
        }
    }
}
