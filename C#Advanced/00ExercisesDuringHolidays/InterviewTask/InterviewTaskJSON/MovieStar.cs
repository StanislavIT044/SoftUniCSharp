namespace InterviewTaskJSON
{
    using Newtonsoft.Json;
    using System;

    public class MovieStar
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Sex { get; set; }

        public string Nationality { get; set; }

        [JsonProperty("dateOfBirth")]
        public DateTime DateOfBirth { get; set; }
    }
}
