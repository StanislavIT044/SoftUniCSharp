using System;

namespace Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private Gender gender;

        public Animal(string name, int age, string male)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = new Gender(male);
        }

        internal string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
            }
        }
        internal int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }
        internal Gender Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            return null;
        }
    }
}
