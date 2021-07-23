using System;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToArray();

            var collection = new ListyIterator<string>(input);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                switch (command)
                {
                    case "move":
                        Console.WriteLine(collection.Move());
                        break;
                    case "print":
                        try
                        {
                            collection.Print();
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "hasnext":
                        Console.WriteLine(collection.HasNext()); 
                            break;
                    case "printall":
                        collection.PrintAll();
                        break;
                }

                command = Console.ReadLine().ToLower();
            }
        }
    }
}
