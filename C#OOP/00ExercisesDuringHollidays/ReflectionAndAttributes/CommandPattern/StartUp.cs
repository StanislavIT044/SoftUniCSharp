namespace CommandPattern
{
    using Core;
    using Core.Contracts;
    using CommandPattern.Core;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICommandInterpreter command = new CommandInterpreter();
            IEngine engine = new Engine(command);
            engine.Run();
        }
    }
}
