using System;

namespace Salery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salery = int.Parse(Console.ReadLine());
            int saleryForPay = salery;

            for (int i = 1; i <= n; i++)
            {
                

                if (saleryForPay >= 0)
                {
                    string currentTab = Console.ReadLine().ToLower();
                    switch (currentTab)
                    {
                        case "facebook":
                        saleryForPay -= 150;
                        break;
                        case "instagram":
                        saleryForPay -= 100;
                        break;
                        case "reddit":
                        saleryForPay -= 50;
                        break;
                    }
                }
                if (saleryForPay == 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    i = n;
                }
            }
            if (saleryForPay > 0)
            {
                Console.WriteLine(saleryForPay);
            }
     
            
        }
    }
}
