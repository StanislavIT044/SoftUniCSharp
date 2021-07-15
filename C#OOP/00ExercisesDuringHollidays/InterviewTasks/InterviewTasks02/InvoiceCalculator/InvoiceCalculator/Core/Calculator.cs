namespace InvoiceCalculator.Core
{
    using System;

    using InvoiceCalculator.Core.Contracts;

    public class Calculator : ICalculator
    {
        public Calculator()
        {
        }

        public decimal DueAmount { get; set; }

        public decimal Calculate(decimal monthlyFee, int numberOfSentSMS, int numberOfSentMMS,
             int minutesToA1BeyondThePackage, int minutesToTelenorBeyondThePackage, int minutesToVivacomBeyondThePackage,
             int minutesInRoaming, decimal usedMBInTheCountryBeyondThePackage,
             decimal usedMbInEUBeyondThePackage, decimal usedMbOutsideEUBeyondThePackage,
             decimal otherFees, decimal discounts)
        {
            this.DueAmount = monthlyFee;

            if (numberOfSentSMS < 50) this.DueAmount += numberOfSentSMS * PricesOfServices.priceOfSmsForSentLessThan50;
            else if (numberOfSentSMS < 100) this.DueAmount += numberOfSentSMS * PricesOfServices.priceOfSmsForSentBetween50And100;
            else if (numberOfSentSMS >= 100) this.DueAmount += numberOfSentSMS * PricesOfServices.priceOfSmsForSentOver100;

            if (numberOfSentMMS < 50) this.DueAmount += numberOfSentMMS * PricesOfServices.priceOfMmsForSentLessThan50;
            else if (numberOfSentMMS < 100) this.DueAmount += numberOfSentMMS * PricesOfServices.priceOfMmsForSentBetween50And100;
            else if (numberOfSentMMS >= 100) this.DueAmount += numberOfSentMMS * PricesOfServices.priceOfMmsForSentOver100;

            this.DueAmount += ((minutesToA1BeyondThePackage * PricesOfServices.priceOfMinutesToA1) +
                ((minutesToTelenorBeyondThePackage + minutesToVivacomBeyondThePackage) * PricesOfServices.priceOfMinutesToOtherOperators) +
                (minutesInRoaming * PricesOfServices.priceOfMinutesInRoaming) +
                (usedMBInTheCountryBeyondThePackage * PricesOfServices.priceOfMb) +
                (usedMbInEUBeyondThePackage * PricesOfServices.priceOfMbInEu) +
                (usedMbOutsideEUBeyondThePackage * PricesOfServices.priceOfMbOutsideEu) +
                otherFees) - discounts;

            return this.DueAmount;
        }
    }
}
