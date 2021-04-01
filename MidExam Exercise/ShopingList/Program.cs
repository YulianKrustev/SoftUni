using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopingList = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            while(command.ToUpper() != "GO SHOPPING!")
            {
                string[] commandArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (commandArg[0].ToUpper())
                {
                    case "URGENT":
                        if (!shopingList.Contains(commandArg[1]))
                        {
                            shopingList.Insert(0, commandArg[1]);
                        }
                        break;
                    case "UNNECESSARY":
                        shopingList.Remove(commandArg[1]);
                        break;
                    case "CORRECT":
                        if (shopingList.Contains(commandArg[1]))
                        {
                            int index = shopingList.FindIndex(x => x == commandArg[1]);
                            shopingList[index] = commandArg[2];

                        }
                        break;
                    case "REARRANGE":
                        if (shopingList.Contains(commandArg[1]))
                        {
                            shopingList.Remove(commandArg[1]);
                            shopingList.Add(commandArg[1]);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", shopingList));
        }
    }
}
