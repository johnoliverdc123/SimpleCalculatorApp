using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorApp
{
    public delegate int GetAnswer(int x, int y);

    class Formula
    {
        public static int getSum1(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int getSum2(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int getSum3(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int getSum4(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}