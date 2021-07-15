namespace ZooPark
{
    using System;

    using ZooPark.Core;
    using ZooPark.Core.Contracts;

    public class Engine : IEngine
    {
        public void Run()
        {
            IZooPark zooPark = new ZooPark();

            zooPark.AddAnimalsInZooPark();
            zooPark.StarvationOfAnimals();
            zooPark.StarvationOfAnimals();
            zooPark.FeedingAnimals();
            zooPark.StarvationOfAnimals();
            zooPark.StarvationOfAnimals();
            zooPark.StarvationOfAnimals();
            zooPark.StarvationOfAnimals();
            zooPark.StarvationOfAnimals();
            Console.WriteLine(zooPark.CountOfDeadAnimals());
        }
    }
}
