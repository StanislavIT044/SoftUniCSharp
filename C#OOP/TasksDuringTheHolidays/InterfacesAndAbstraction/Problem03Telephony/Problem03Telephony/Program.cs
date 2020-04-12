using System;

namespace Problem03Telephony
{
    class Program
    {
        static void Main()
        {
            string driver = Console.ReadLine();

            IFerrari car = new Ferrari(driver);

            Console.WriteLine($"{car.Model}/{car.Brakes()}/{car.Gas()}/{car.Driver}");
        }
    }
}
