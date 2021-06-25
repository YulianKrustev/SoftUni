using System;

namespace WorkShop
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomStack stack = new CustomStack();

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(stack.Pop()); 
            }

            stack.ForEach(x => Console.WriteLine(x));
        }
    }
}
