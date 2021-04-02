using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            int minNum = CompareIntiger(numberOne, numberTwo, numberThree);

            Console.WriteLine(minNum);
        }

        private static int CompareIntiger(int numberOne, int numberTwo, int numberThree)
        {
            return Math.Min(numberTwo, (Math.Min(numberOne, numberThree)));
        }
    }
}
