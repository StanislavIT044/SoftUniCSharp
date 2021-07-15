namespace InvoiceCalculator.Core.Contracts
{
    using System;

    public interface ICalculator
    {
        decimal Calculate(decimal MonthlyFee, int NumberOfSentSMS, int NumberOfSentMMS,
            int MinutesToA1BeyondThePackage, int MinutesToTelenorBeyondThePackage, int MinutesToVivacomBeyondThePackage,
             int MinutesInRoaming, decimal UsedMBInTheCountryBeyondThePackage,
             decimal UsedMbInEUBeyondThePackage, decimal UsedMbOutsideEUBeyondThePackage,
             decimal OtherFees, decimal Discounts);
    }
}
