using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            int sumOfOneAndTwo = Sum(numberOne, numberTwo);
            int subtractNumbers = Subtract(sumOfOneAndTwo, numberThree);
            Console.WriteLine(subtractNumbers);
        }

        private static int Subtract(int sumOfOneAndTwo, int numberThree)
        {
            return sumOfOneAndTwo - numberThree;
        }

        private static int Sum(int numberOne, int numberTwo)
        {
            return numberTwo + numberOne;
        }
    }
}
