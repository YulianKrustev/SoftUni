using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            string output = string.Empty;
            for (int i = 0; i < countNumbers; i++)
            {
                string numAsText = Console.ReadLine();
                if (numAsText.Length == 3)
                {
                    int number = 101 + int.Parse(numAsText[0].ToString());
                    output += (((char)number).ToString());
                }
                else if (numAsText.Length == 2)
                {
                    int number = 100 + int.Parse(numAsText[0].ToString());
                    output += (((char)number).ToString());
                }
                else if (numAsText.Length == 1)
                {
                    int number = 99 + int.Parse(numAsText[0].ToString());
                    output += (((char)number).ToString());
                }

            }

            Console.WriteLine(output);


        }
    }
}
