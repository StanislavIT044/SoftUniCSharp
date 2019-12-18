namespace Telephony
{
    public interface ISmartphone
    {
        string Calling(string[] numbers);

        string Browsing(string[] URLs);
    }
}
