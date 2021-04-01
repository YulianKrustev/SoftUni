using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberAsText = Console.ReadLine();
            int factorial = 1;
            int factorialSum = 0;
            int Number = int.Parse(numberAsText);
            
            for (int i = 0; i < numberAsText.Length; i++)
            {
                int currentNumber = int.Parse(numberAsText[i].ToString());
                for (int j = currentNumber; j > 1; j--)
                {
                    factorial *= j;
                }
                factorialSum += factorial;
                factorial = 1;
            }
            if (Number == factorialSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
