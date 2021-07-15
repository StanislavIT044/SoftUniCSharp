namespace ZooPark.Core.Contracts
{
    public interface IZooPark
    {
        void AddAnimalsInZooPark();

        void StarvationOfAnimals();

        void FeedingAnimals();

        int CountOfDeadAnimals();
    }
}
