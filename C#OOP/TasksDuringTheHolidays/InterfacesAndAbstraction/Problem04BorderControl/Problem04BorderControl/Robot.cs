namespace Problem04BorderControl
{
    public class Robot : Passanger, IRobot
    {
        public Robot(string name, string id)
            : base(id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name { get; set; }

        public string Id { get; }
    }
}
