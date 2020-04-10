using System;
using System.Collections.Generic;
using System.Text;

namespace Problem03ShoppingSpree
{
    internal class Person
    {
        private string name;
        private double money;
        private List<Product> products;

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<Product>();
        }

        public string Name 
        {
            get 
            {
                return name;
            }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }

        public double Money 
        {
            get 
            {
                return money;
            } 
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;
            } 
        }

        public List<Product> Products 
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }

        internal string buyAProduct(Product product)
        {
            if (product.Price > this.Money)
            {
                return $"{this.Name} can't afford {product.Name}";
            }

            this.Products.Add(product);

            this.Money -= product.Price;

            return $"{this.Name} bought {product.Name}";
        }
    }
}
