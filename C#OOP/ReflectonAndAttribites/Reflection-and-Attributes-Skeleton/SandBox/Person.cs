namespace SandBox
{
    using System.ComponentModel.DataAnnotations;

    public class Person
    {
        public Person(string firstName, int age)
        {
            this.FirstName = firstName;
            this.Age = age;
        }

        [MyRequired]
        public string FirstName { get; set; }

        [Range(18, 65)]
        public int Age { get; set; }
    }
}
