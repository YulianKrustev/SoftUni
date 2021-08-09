using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList rl = new RandomList();
            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {
                rl.Add(r.Next(0, 3).ToString());
            }
        }
    }
}
