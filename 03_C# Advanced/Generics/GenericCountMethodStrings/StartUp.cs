using System;

namespace GenericCountMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> list = new Box<string>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string current = Console.ReadLine();
                list.Add(current);
            }

            string elementToCompare = Console.ReadLine();
            list.Compare(elementToCompare);

            Console.WriteLine(list.CountGreater);
        }
    }
}
