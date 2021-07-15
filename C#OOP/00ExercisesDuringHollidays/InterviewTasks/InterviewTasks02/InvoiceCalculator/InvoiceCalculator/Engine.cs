namespace InvoiceCalculator
{
    using System;

    using InvoiceCalculator.Core;
    using InvoiceCalculator.Core.Contracts;

    public class Engine : IEngine
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Enter montly fee:");
                decimal monthlyFee = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter number of sent SMS:");
                int numberOfSentSMS = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter number of sent MMS:");
                int numberOfSentMMS = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter minutes to A1 beyond the package:");
                int minutesToA1BeyondThePackage = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter minutes to telenor beyond the package:");
                int minutesToTelenorBeyondThePackage = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter minutes to vivacom beyond the package:");
                int minutesToVivacomBeyondThePackage = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter minutes in roaming:");
                int minutesInRoaming = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter used MB in the country beyond the package:");
                decimal usedMBInTheCountryBeyondThePackage = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter useb MB in EU beyond the package:");
                decimal usedMbInEUBeyondThePackage = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter used MB outside EU beyond the package:");
                decimal usedMbOutsideEUBeyondThePackage = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter other fees:");
                decimal otherFees = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter discounds:");
                decimal discounts = decimal.Parse(Console.ReadLine());

                ICalculator calculator = new Calculator();
                decimal dueAmount = calculator.Calculate(monthlyFee, numberOfSentSMS, numberOfSentMMS,
                    minutesToA1BeyondThePackage, minutesToTelenorBeyondThePackage, minutesToVivacomBeyondThePackage, minutesInRoaming,
                    usedMBInTheCountryBeyondThePackage, usedMbInEUBeyondThePackage, usedMbOutsideEUBeyondThePackage,
                    otherFees, discounts);

                Console.WriteLine($"Due amount is: {dueAmount:f2} lv.");
            }
            catch (Exception ex)
            {
                if (ex.GetType().ToString() == "System.FormatException")
                {
                    Console.WriteLine("Incorrect input parameters!");
                }
                else
                {
                    Console.WriteLine("There is an error!");
                }
            }          
        }
    }
}
