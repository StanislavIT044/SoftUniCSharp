namespace Telephony
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] URLs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            ISmartphone phone = new Smartphone(numbers, URLs);

            Console.WriteLine(phone.Calling(numbers));
            Console.WriteLine(phone.Browsing(URLs));
        }
    }
}
