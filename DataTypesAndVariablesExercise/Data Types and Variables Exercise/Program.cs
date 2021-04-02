using System;

namespace Data_Types_and_Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int result = ((firstNumber + secondNumber) / thirdNumber) * fourthNumber;
            Console.WriteLine(result);
        }
    }
}
