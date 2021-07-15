namespace InvoiceCalculator.Core
{
    public static class PricesOfServices
    {
        // SMS prices
        public const decimal priceOfSmsForSentLessThan50 = 0.18m;
        public const decimal priceOfSmsForSentBetween50And100 = 0.16m;
        public const decimal priceOfSmsForSentOver100 = 0.11m;

        // MMS prices
        public const decimal priceOfMmsForSentLessThan50 = 0.25m;
        public const decimal priceOfMmsForSentBetween50And100 = 0.23m;
        public const decimal priceOfMmsForSentOver100 = 0.18m;

        // Minutes prices
        public const decimal priceOfMinutesToA1 = 0.03m;
        public const decimal priceOfMinutesToOtherOperators = 0.09m;
        public const decimal priceOfMinutesInRoaming = 0.15m;

        // MB prices
        public const decimal priceOfMb = 0.2m;
        public const decimal priceOfMbInEu = 0.05m;
        public const decimal priceOfMbOutsideEu = 0.20m;
    }
}
