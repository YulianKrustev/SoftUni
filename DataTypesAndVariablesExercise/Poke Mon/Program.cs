using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int pokeCount = 0;
            double halfN =  n * 0.5;

            while (n >= m)
            {
                pokeCount++;
                n -= m;
                if (n == halfN && y > 0)
                {
                        n /= y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(pokeCount);
        }
    }
}
