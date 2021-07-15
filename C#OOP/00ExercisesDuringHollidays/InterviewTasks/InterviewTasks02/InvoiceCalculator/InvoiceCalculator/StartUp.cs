namespace InvoiceCalculator
{
    using InvoiceCalculator.Core.Contracts;

    class StartUp
    {
        static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
