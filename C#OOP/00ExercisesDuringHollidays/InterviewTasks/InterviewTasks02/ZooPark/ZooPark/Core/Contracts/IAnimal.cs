namespace ZooPark.Core.Contracts
{
    public interface IAnimal
    {
        void Starvation();

        void Feeding(int points);

        void Dying();
    }
}
