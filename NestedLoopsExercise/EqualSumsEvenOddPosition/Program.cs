using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            

            for (int i = startNumber; i <= endNumber; i++)
            {
                string numAsText = i.ToString();
                int oddNumber = 0;
                int evenNumber = 0;
                for (int index = 0; index < numAsText.Length; index++)
                {
                    int digit = int.Parse(numAsText[index].ToString());
                    if (index % 2 == 0)
                    {
                        evenNumber += digit;
                    }
                    else
                    {
                        oddNumber += digit;
                    }
                }

                if (oddNumber == evenNumber)
                {
                    Console.Write($"{i} ");
                }
               
            }
        }
    }
}
