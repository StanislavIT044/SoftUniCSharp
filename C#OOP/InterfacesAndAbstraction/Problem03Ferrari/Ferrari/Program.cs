namespace Ferrari
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string driversName = Console.ReadLine();

            Ferrari ferrari = new Ferrari(driversName); 

            Console.WriteLine($"{ferrari.Model}/{ferrari.Brakes}/{ferrari.GasPedal}/{ferrari.Driver}");
        }
    }
}
