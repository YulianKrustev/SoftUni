using System;

namespace Exsercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            if (numberOne > numberTwo && numberOne > numberThree && numberTwo >= numberThree)
            {
                Console.WriteLine(numberOne);
                Console.WriteLine(numberTwo);
                Console.WriteLine(numberThree);
            }
            if (numberOne > numberTwo && numberOne > numberThree && numberTwo < numberThree)
            {
                Console.WriteLine(numberOne);
                Console.WriteLine(numberThree);
                Console.WriteLine(numberTwo);
            }
            if (numberTwo > numberOne && numberTwo > numberThree && numberOne <= numberThree)
            {
                Console.WriteLine(numberTwo);
                Console.WriteLine(numberThree);
                Console.WriteLine(numberOne);
            }
            if (numberTwo > numberOne && numberTwo > numberThree && numberOne > numberThree)
            {
                Console.WriteLine(numberTwo);
                Console.WriteLine(numberOne);
                Console.WriteLine(numberThree);
            }
            if (numberThree > numberOne && numberThree > numberTwo && numberOne >= numberTwo)
            {
                Console.WriteLine(numberThree);
                Console.WriteLine(numberOne);
                Console.WriteLine(numberTwo);
            }
            if (numberThree > numberOne && numberThree > numberTwo && numberOne < numberTwo)
            {
                Console.WriteLine(numberThree);
                Console.WriteLine(numberTwo);
                Console.WriteLine(numberOne);
            }
        }
    }
}
