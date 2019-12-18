using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyHeaven
{
    public class Restaurant
    {
        private List<Salad> salads;
        public Restaurant(string name)
        {
            this.Name = name;
            salads = new List<Salad>();
        }
        public string Name { get; set; }

        public void Add(Salad salad)   //Add salad
        {
            salads.Add(salad);
        }

        public bool Buy(string name)    //removes a salad by given name, if such exists, and returns boolean
        {
            foreach (var salad in salads)
            {
                if (salad.Name == name)
                {
                    salads.Remove(salad);
                    return true;
                }
            }

            return false;
        }

        public string GetHealthiestSalad()
        {
            int minCal = int.MaxValue;
            string saladToPrint = string.Empty;
            foreach (var salad in salads)
            {
                if (salad.GetTotalCalories() < minCal)
                {
                    minCal = salad.GetTotalCalories();
                    saladToPrint = salad.Name;
                }
            }

            return saladToPrint;
        }

        public string GenerateMenu()
        {
            string menu = $"{this.Name} have {salads.Count} salads:";
            foreach (var salad in salads)
            {
                menu += $"{Environment.NewLine}{salad.ToString()}";
            }
            return menu;
        }

    }
}
