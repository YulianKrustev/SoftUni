using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            while (command.ToUpper() != "CRAFT!")
            {
                string[] commandArg = command.Split(" - ");
                string action = commandArg[0];
                string item = commandArg[1];

                switch (action.ToUpper())
                {
                    case "COLLECT":
                        if (!journal.Contains(item))
                        {
                            journal.Add(item);
                        }
                        break;

                    case "DROP":
                        journal.Remove(item);
                        break;

                    case "COMBINE ITEMS":
                        string[] newItem = item.Split(":");
                        if (journal.Contains(newItem[0]))
                        {
                            int index = journal.FindIndex(x => x == newItem[0]);
                            journal.Insert(index + 1, newItem[1]);
                        }
                        break;

                    case "RENEW":
                        if (journal.Contains(item))
                        {
                            journal.Remove(item);
                            journal.Add(item);
                        }
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
