namespace CommandPattern.Core
{
    using System;
    using System.Linq;
    using CommandPattern.Core.Commands;
    using Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] inputArgs = args.Split(" ",
                StringSplitOptions.RemoveEmptyEntries);

            string commandName = inputArgs[0];
            string[] commandArgs = inputArgs.Skip(1).ToArray();

            ICommand command = null;

            if (commandName == "Hello")
            {
                command = new HelloCommand();
            }
            else if (commandName == "Exit")
            {
                command = new ExitCommand();
            }
            else
            {
                throw new ArgumentException();
            }

            string result = command.Execute(commandArgs);

            return result;
        }
    }
}
