using System;

namespace Problem5DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secoundDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();
            double result = dateModifier.GetDifferenceInDaysBetweenTwoDates(firstDate, secoundDate);

            Console.WriteLine(result);
        }
    }
}
