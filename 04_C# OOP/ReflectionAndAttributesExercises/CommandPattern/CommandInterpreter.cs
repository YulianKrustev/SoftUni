using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern
{
    public class CommandInterpreter : Core.Contracts.ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] inputArgs = args.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
            string commandName = (inputArgs[0] + "Command").ToLower();
            string[] commandArgs = inputArgs.Skip(1).ToArray();

            Type commmandType = Assembly.GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(n => n.Name.ToLower() == commandName);

            if (commmandType == null)
            {
                throw new ArgumentException("Invalid command type");
            }

            ICommand commandInstance = Activator.CreateInstance(commmandType) as ICommand;

            string result = commandInstance.Execute(commandArgs);

            return result;
        }
    }
}