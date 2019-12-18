namespace Problem3ShoppingSpree
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string[] persons = Console.ReadLine()
                    .Split(';', StringSplitOptions.RemoveEmptyEntries);

            string[] products = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Person> personsInfo = new Dictionary<string, Person>();
            Dictionary<string, Product> productsInfo = new Dictionary<string, Product>();

            try
            {
                for (int i = 0; i < persons.Length; i++)
                {
                    string[] personTokens = persons[i]
                        .Split('=', StringSplitOptions.RemoveEmptyEntries);

                    decimal personMoney = decimal.Parse(personTokens[1]);
                    Person person = new Person(personTokens[0], personMoney);

                    personsInfo.Add(personTokens[0], person);
                }

                for (int i = 0; i < products.Length; i++)
                {
                    string[] productTokens = products[i]
                        .Split('=', StringSplitOptions.RemoveEmptyEntries);

                    decimal productCost = decimal.Parse(productTokens[1]);

                    productsInfo.Add(productTokens[0], new Product(productTokens[0], productCost));
                }

                while (true)
                {
                    string command = Console.ReadLine();

                    if (command == "END")
                    {
                        break;
                    }

                    string[] tokens = command
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string client = tokens[0];
                    string productToBuy = tokens[1];
                    decimal productCost = productsInfo[productToBuy].Cost;

                    if (productCost <= personsInfo[client].Money)
                    {
                        personsInfo[client].Money -= productCost;
                        personsInfo[client].Products.Add(productToBuy);

                        Console.WriteLine($"{client} bought {productToBuy}");
                    }
                    else
                    {
                        Console.WriteLine($"{client} can't afford {productToBuy}");
                    }
                }

                foreach (var person in personsInfo)
                {
                    if (person.Value.Products.Count > 0)
                    {
                        Console.WriteLine($"{person.Value.Name} - {string.Join(", ", person.Value.Products)}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Value.Name} - Nothing bought");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
