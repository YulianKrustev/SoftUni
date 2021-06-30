using System;

namespace WorkShop
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList list = new DoubleLinkedList();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);

            list.RemoveLast(); 


            int[] array = list.ToArray();

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
