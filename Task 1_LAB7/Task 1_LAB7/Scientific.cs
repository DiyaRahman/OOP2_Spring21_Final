using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_LAB7
{
    class Scientific : BasicCalculatorInterface, ScientificCalculatorInterface
    {
        public int FirstNo { get; set; }
        public int SecondNo { get; set; }

        public Scientific() { }

        public Scientific(int firstno, int secondno)
        {
            FirstNo = firstno;
            SecondNo = secondno;
        }
        public int XtoY(int x, int y)
        {
            return (int)Math.Pow(x,y);
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
