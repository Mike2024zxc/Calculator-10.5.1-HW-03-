using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CalculatorWithLogger
{
    public class CalculatorSum : ISum
    {
        ILogger Logger { get; }

        public CalculatorSum(ILogger logger)
        {
            Logger = logger;
        }

        int  ISum.Sum(int numOne, int numTwo)
        {
            Logger.Event("Калькулятор начал свою работу");
            Thread.Sleep(3000);
            
            int rez = numOne + numTwo;
            Logger.Event("Калькулятор окончил свою работу");

            return rez;
            
        }
    }
}
