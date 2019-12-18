namespace Problem3ShoppingSpree
{
    using System;

    internal class Product
    {
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name { get; set; }

        public decimal Cost 
        {
            get
            {
                return cost;
            }
            set 
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }

                cost = value;
            }
        }
    }
}
