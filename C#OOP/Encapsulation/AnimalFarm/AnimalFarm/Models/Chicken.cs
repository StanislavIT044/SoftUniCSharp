namespace AnimalFarm.Models
{
    using System;

    internal class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;

        internal Chicken(string name, int age)
        {
            if (name == null || name.Contains(" "))
            {
                throw new ArgumentException("Name cannot be empty.");
            }
            else
            {
                this.Name = name;
            }

            if (age < MinAge || age > MaxAge)
            {
                throw new ArgumentException("Age should be between 0 and 15.");
            }
            else
            {
                this.Age = age;
            }
        }

        internal string Name { get; private set; }

        public int Age { get; private set; }

        internal double ProductPerDay
        {
			get
			{				
				return this.CalculateProductPerDay();
			}
        }

        private double CalculateProductPerDay()
        {
            if (this.Age <= 3)
            {
                return 1.5;
            }
            else if (this.Age <= 7)
            {
                return 2;
            }
            else if (this.Age <= 11)
            {
                return 1;
            }
            else
            {
                return 0.75;
            }
        }
    }
}
