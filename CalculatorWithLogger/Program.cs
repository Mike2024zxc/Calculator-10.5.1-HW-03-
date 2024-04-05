using System;

namespace CalculatorWithLogger
{
    internal class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            CalculatorSum calculatorSum = new CalculatorSum(Logger);
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите первое число:");
                    int numOne = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    int numTwo = Convert.ToInt32(Console.ReadLine());

                    int rez = ((ISum)calculatorSum).Sum(numOne, numTwo);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Сумма чисел: {0} + {1} = {2}", numOne,numTwo,rez);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (FormatException) 
                {
                    Logger.Error("Некорректное значение");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
