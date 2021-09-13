using MilitaryElite.Core;
using System;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ICommandInterpreter command = new CommandInterpreter(); 
            Engine engine = new Engine(command);
            engine.Run();
        }
    }
}
