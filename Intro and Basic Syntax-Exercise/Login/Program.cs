using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string useerName = Console.ReadLine();
            string passWord = string.Empty;
            int wrongPass = 1;

            for (int i = useerName.Length -1; i >= 0; i--)
            {
                passWord += useerName[i];
            }
            string enterPass = Console.ReadLine();
            while (passWord != enterPass)
            {
                wrongPass++;
                Console.WriteLine("Incorrect password. Try again.");
                enterPass = Console.ReadLine();
                if (wrongPass == 4)
                {
                    Console.WriteLine($"User {useerName} blocked!");
                    break;
                }
            }
            if (wrongPass != 4)
            {
                Console.WriteLine($"User {useerName} logged in.");
            }
            
        }
    }
}
