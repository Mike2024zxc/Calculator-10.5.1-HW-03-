using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorSum calculatorSum = new CalculatorSum();  

            while(true)
            {
                try
                {
                    Console.WriteLine("Введите первое число:");
                    int numOne = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    int numTwo = Convert.ToInt32(Console.ReadLine());

                    int rez = calculatorSum.Sum(numOne, numTwo);    
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Сумма чисел: {0} + {1} = {2}", numOne,numTwo,rez);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Некорректное значение");
                }
            }
        }
    }
}
