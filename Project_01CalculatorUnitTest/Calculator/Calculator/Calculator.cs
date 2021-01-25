using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
   public class Calculator
    {
        public double Add(double number1,double number2)
        {
            var result= number1 + number2;
            return result;
        }
        public double Subtract(double number1, double number2)
        {
            var result = number1 - number2;
            return result;
        }
        public double Mul(double number1, double number2)
        {
            var result = number1 * number2;
            return result;
        }
        public  double Divide(double number1, double number2)
        {
            if(number2 != 0)
            {
                var result = number1 / number2;
                return result;
            }
            else
            {
                // Custome Business Logic for Divide By Zero
                return 0;
            }
            
        }
    }
}
