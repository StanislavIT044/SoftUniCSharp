namespace Problem5BorderControl
{
    public class Robot : Passanger, IRobot
    {
        public Robot(string model, string id)
            : base(id)
        {
            this.Model = model;
        }
        public string Model { get; }
        public string Id { get; }
    }
}
