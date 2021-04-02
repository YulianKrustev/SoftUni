using System;

namespace More_ExerciseMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            var input = Console.ReadLine();

            bool isInt = int.TryParse(input, out _);
            bool isDouble = double.TryParse(input, out _);

            
            if (isInt)
            {
                Console.WriteLine($"{int.Parse(input) * 2}");
            }
            else if (isDouble)
            {
                Console.WriteLine(double.Parse(input) * 1.5);
            }
            else
            {
                Console.WriteLine($"${input}$");
            }
            
        }
    }
}
