using System;

namespace Common_element
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split();
            string[] arrayTwo = Console.ReadLine().Split();


            foreach (var item1 in arrayTwo)
            {
                foreach (var item2 in arrayOne)
                {
                    if (item1 == item2)
                    {
                        Console.Write(item2+" ");
                    }
                }
            }
                
        }
    }
}
