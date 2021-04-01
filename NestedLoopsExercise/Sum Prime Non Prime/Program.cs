using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int primeNums = 0;
            int notPrimeNums = 0;

            while (number != "stop")
            {
                int currentNum = int.Parse(number);
                bool isPrime = true;

                if (currentNum == 1)
                {
                    notPrimeNums += currentNum;
                    number = Console.ReadLine();
                    continue;
                }

                if (currentNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                    
                }

                for (int i = 2; i < currentNum; i++)
                {
                    if (currentNum % i == 0)
                    {
                        notPrimeNums += currentNum;
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true && currentNum > 0)
                {
                    primeNums += currentNum;
                }
                number = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNums}");
            Console.WriteLine($"Sum of all non prime numbers is: {notPrimeNums}");
        }
    }
}
