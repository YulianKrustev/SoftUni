using CollectionHierarchy.Contracts;
using System;

namespace CollectionHierarchy
{
    public class Engine
    {
        public void Run()
        {
            string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int countOfRemoves = int.Parse(Console.ReadLine());
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            foreach (var element in strings)
            {
                Console.Write(addCollection.Add(element) + " "); 
            }

            Console.WriteLine();

            foreach (var element in strings)
            {
                Console.Write(addRemoveCollection.Add(element) + " ");
            }

            Console.WriteLine();

            foreach (var element in strings)
            {
                Console.Write(myList.Add(element) + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < countOfRemoves; i++)
            {
                Console.Write(addRemoveCollection.Remove() + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < countOfRemoves; i++)
            {
                Console.Write(myList.Remove() + " ");
            }
        }
    }
}
