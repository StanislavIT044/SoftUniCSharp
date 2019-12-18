using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyHeaven
{
    public class Salad
    {
        private List<Vegetable> vegetables;
        private int calSum;
        public Salad(string name)
        {
            this.Name = name;
            vegetables = new List<Vegetable>();
            calSum = 0;
        }
        public string Name { get; set; }

        public int GetTotalCalories()   //returns the sum of all vegetable calories in the salad
        {
            int sumOfCalories = 0;
            foreach (var vegetable in vegetables)
            {
                sumOfCalories += vegetable.Calories;
            }
            return sumOfCalories;
        }

        public int GetProductCount()    //returns the number of products
        {
            return vegetables.Count;
        }

        public void Add(Vegetable product)
        {
            vegetables.Add(product);
            calSum += product.Calories;
        }

        public override string ToString()
        {
            string print = $"* Salad {this.Name} is {this.calSum} calories and have {vegetables.Count} products:";

            foreach (var vegetable in vegetables)
            {
                //print += $"{Environment.NewLine}  - {vegetable.Name} have {vegetable.Calories} calories";
                print += $"{Environment.NewLine}{vegetable.ToString()}";
            }
            return print;
        }
    }
}
