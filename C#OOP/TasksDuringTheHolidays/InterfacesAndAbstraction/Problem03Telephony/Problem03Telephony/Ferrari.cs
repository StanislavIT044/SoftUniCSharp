namespace Problem03Telephony
{
    public class Ferrari : IFerrari
    {
        public Ferrari(string driver)
        {
            this.Model = "488-Spider";
            this.Driver = driver;
        }

        public string Model { get; set; }
        public string Driver { get; set; }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Gas!";
        }
    }
}
