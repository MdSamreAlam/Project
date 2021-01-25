using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class ClassicProgram
    {
        public bool IsPrime(int a)
        {
            bool result = true;
            if (a >= 0)
            {
                for (int i = 2; i <= a / 2; i++)
                {
                    if (a % i == 0)
                    {
                        return false;
                        break;
                    }
                }
                return result;
            }
            else
            {
                return false;
            }


        }
        public bool IsEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsOdd(int a)
        {
            if(a%2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       

    }
}

