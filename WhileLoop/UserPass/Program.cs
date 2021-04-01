using System;

namespace UserPass
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = Console.ReadLine();
            string truePass = "";

            while (pass != truePass)
            {
                truePass = Console.ReadLine();

            }

            Console.WriteLine("Welcome " + name + "!");
        }
    }
}
