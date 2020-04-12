namespace Problem03Telephony
{
    public interface IFerrari
    {
        string Model { get; set; }

        string Driver { get; set; }

        string Brakes();

        string Gas();
    }
}
