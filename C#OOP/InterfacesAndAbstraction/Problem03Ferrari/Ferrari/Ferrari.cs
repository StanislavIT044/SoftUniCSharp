namespace Ferrari
{
    public class Ferrari : ICar
    {
        public Ferrari(string driver)
        {
            this.Driver = driver;
            this.Model = "488-Spider";
            this.Brakes = "Brakes!";
            this.GasPedal = "Gas!";
        }

        public string Driver { get; set; }
        public string Model { get; set; }
        public string GasPedal { get; set; }
        public string Brakes { get; set; }
    }
}
