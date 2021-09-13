using System;

namespace MilitaryElite.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = new CommandInterpreter();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                try
                {
                    string[] inputInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string result = commandInterpreter.Read(inputInfo);

                    Console.WriteLine(result);
                }
                catch (Exception)
                {
                }

                input = Console.ReadLine();
            }
        }
    }
}
