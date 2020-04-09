namespace Animals
{
    public class Gender
    {
        private string male;

        public Gender(string male)
        {
            this.Male = male;
        }

        public string Male
        {
            get
            {
                return male;
            }
            set
            {
                male = value;
            }
        }
    }
}
