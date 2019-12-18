namespace Problem3ShoppingSpree
{
    using System;
    using System.Collections.Generic;

    internal class Person
    {
        private string name;
        private decimal money;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<string>();
        }

        public string Name 
        {
            get 
            {
                return name; 
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                else
                {
                    name = value;
                }
            }
        }

        public decimal Money
        {
            get 
            { 
                return money; 
            }
            
            set 
            {
                if (value >= 0)
                {
                    money = value;
                }
                else
                {
                    throw new ArgumentException("Money cannot be negative");
                }
            }
        }

        public List<string> Products { get; set; }
    }
}
