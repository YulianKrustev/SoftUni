using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";

            while (text != "Stop")
            {
                Console.WriteLine(text);
                text = Console.ReadLine();
                
            }
        }
    }
}
