using System;

namespace Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = string.Empty;
            int[] finalNumbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                input = Console.ReadLine();
                int sum = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    if (
                           input[j] == 'a' 
                        || input[j] == 'A' 
                        || input[j] == 'e' 
                        || input[j] == 'E' 
                        || input[j] == 'U' 
                        || input[j] == 'u' 
                        || input[j] == 'o' 
                        || input[j] == 'O'
                        || input[j] == 'I'
                        || input[j] == 'i'
                        )
                    {
                        sum += (int)input[j] * input.Length; 
                    }
                    else
                    {
                        sum += (int)input[j] / input.Length;
                    }
                    
                }
                finalNumbers[i] = sum;

            }
            Array.Sort(finalNumbers);
            for (int i = 0; i < finalNumbers.Length; i++)
            {
                Console.WriteLine(finalNumbers[i]);
            }

        }
    }
}
