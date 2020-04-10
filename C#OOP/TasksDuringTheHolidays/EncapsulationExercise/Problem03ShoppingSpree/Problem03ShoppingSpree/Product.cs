using System;
using System.Collections.Generic;
using System.Text;

namespace Problem03ShoppingSpree
{
    public class Product
    {
        private string name;
        private double money;

        public Product(string name, double money)
        {
            this.Name = name;
            this.Money = money;
        }

        public string Name 
        {
            get 
            {
                return name;
            }
            set
            {   

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

            }
        }
    }
}
