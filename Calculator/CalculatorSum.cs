using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalculatorSum : ISum
    {
        public int Sum(int numOne, int numTwo)
        {
            int rez = numOne + numTwo;

            return rez;
        }
    }
}
