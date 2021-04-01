using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string calculation = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            PrintCalculation(calculation, firstNumber, secondNumber);
        }

        private static void PrintCalculation(string calculation, int firstNumber, int secondNumber)
        {
            int result = 0;
            switch (calculation)
            {
                case "add": result = firstNumber + secondNumber;
                    break;
                case "subtract": result = firstNumber - secondNumber;
                    break;
                case "multiply": result = firstNumber * secondNumber;
                    break;
                case "divide": result = firstNumber / secondNumber;
                    break;               
            }
            Console.WriteLine(result);
        }
    }
}
