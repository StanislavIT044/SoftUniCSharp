namespace Problem01InvoiceCalculator
{
    using System;

    public class InvoiceCalculator
    {
        public InvoiceCalculator(double monthlyFee, int numberOfSentSMS, int numberOfSentMMS, int minutesToA1OutsideThePackage,
            int minutesToTelenorOutsideThePackage, int minutesToVivacomOutsideThePackage, int minutesInRoaming,
            int usedMBInTheCountryOutsideThePackage, int usedMBInTheEUOutsideThePackage,
            int usedMBOutsideTheEUOutsideThePackage, double otherFees, double discounts)
        {
            this.MonthlyFee = monthlyFee;
            this.NumberOfSentSMS = numberOfSentSMS;
            this.NumberOfSentMMS = numberOfSentMMS;
            this.MinutesToA1OutsideThePackage = minutesToA1OutsideThePackage;
            this.MinutesToTelenorOutsideThePackage = minutesToTelenorOutsideThePackage;
            this.MinutesToVivacomOutsideThePackage = minutesToVivacomOutsideThePackage;
            this.MinutesInRoaming = minutesInRoaming;
            this.UsedMBInTheCountryOutsideThePackage = usedMBInTheCountryOutsideThePackage;
            this.UsedMBInTheEUOutsideThePackage = usedMBInTheEUOutsideThePackage;
            this.UsedMBOutsideTheEUOutsideThePackage = usedMBOutsideTheEUOutsideThePackage;
            this.OtherFees = otherFees;
            this.Discounts = discounts;
        }

        public double MonthlyFee { get; private set; }

        public int NumberOfSentSMS { get; private set; }

        public int NumberOfSentMMS { get; private set; }

        public int MinutesToA1OutsideThePackage { get; private set; }

        public int MinutesToTelenorOutsideThePackage { get; private set; }

        public int MinutesToVivacomOutsideThePackage { get; private set; }

        public int MinutesInRoaming { get; private set; }

        public int UsedMBInTheCountryOutsideThePackage { get; private set; }

        public int UsedMBInTheEUOutsideThePackage { get; private set; }

        public int UsedMBOutsideTheEUOutsideThePackage { get; private set; }

        public double OtherFees { get; private set; }

        public double Discounts { get; private set; }

        public double InvoiceCalculation()
        {
            return 0;
        }
    }
}
