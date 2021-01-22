using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
   public class Calculator
    {
        public int Add(int number1,int number2)
        {
            var result= number1 + number2;
            return result;
        }
        public int Subtract(int number1, int number2)
        {
            var result = number1 - number2;
            return result;
        }
        public int Mul(int number1, int number2)
        {
            var result = number1 * number2;
            return result;
        }
    }
}
