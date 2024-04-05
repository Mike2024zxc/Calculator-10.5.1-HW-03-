using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorWithLogger
{
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}
