namespace CommandPattern.Core.Commands
{
    using System;
    using Core.Contracts;
    public class HelloCommand : ICommand
    {
        public string Execute(string[] args)
        {
            string name = args[0];

            return $"Hello, {name}";
        }
    }
}
