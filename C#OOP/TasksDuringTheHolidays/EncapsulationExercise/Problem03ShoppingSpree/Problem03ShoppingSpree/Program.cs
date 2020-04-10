using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem03ShoppingSpree
{
    class Program
    {
        static void Main()
        {
            List<string> personsInfo = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> productsInfo = Console.ReadLine()
               .Split(";", StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, Person> persons = new Dictionary<string, Person>();
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            try
            {
                for (int i = 0; i < personsInfo.Count; i++)
                {
                    string[] tokens = personsInfo[i]
                        .Split("=", StringSplitOptions.RemoveEmptyEntries);

                    Person p = new Person(tokens[0], int.Parse(tokens[1]));

                    persons.Add(tokens[0], p);
                }

                for (int i = 0; i < productsInfo.Count; i++)
                {
                    string[] tokens = productsInfo[i]
                        .Split("=", StringSplitOptions.RemoveEmptyEntries);

                    Product p = new Product(tokens[0], int.Parse(tokens[1]));

                    products.Add(tokens[0], p);
                }

                while (true)
                {
                    string command = Console.ReadLine();

                    if (command == "END")
                    {
                        break;
                    }

                    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string person = tokens[0];
                    Product prod = products[tokens[1]];

                    Console.WriteLine(persons[person].buyAProduct(prod));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (var per in persons)
            {
                string str = $"{per.Value.Name} - ";

                if (per.Value.Products.Count == 0)
                {
                    Console.WriteLine($"{per.Value.Name} - Nothing bought");
                }
                else
                {
                   

                    foreach (var prd in per.Value.Products)
                    {
                        str += $"{prd.Name}, ";
                    }
                }

                if (str.Length > 14)
                {
                    str.TrimEnd();
                    str = str.Substring(0, str.Length - 2);

                    Console.WriteLine(str);
                }
            }

            

        }
    }
}
