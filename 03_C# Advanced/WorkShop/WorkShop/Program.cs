using System;

namespace WorkShop
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList();
            
            for (int i = 0; i < 20; i++)
            {
                list.Add(i);
            }

            list.RemoveAt(1);
            list.Insert(1, 1);

            if (list.Contains(1))
            {
                list.Swap(1, 19);
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
