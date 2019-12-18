namespace ValidationAttributes
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var person = new Person
             (
                 "Gosho",
                 30
             );

            bool isValidEntity = Validator.IsValid(person);

            Console.WriteLine(isValidEntity);
        }
    }
}
