using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> rabbits;
        public Cage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            rabbits = new List<Rabbit>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get => rabbits.Count; }

        public void Add(Rabbit rabbit)   //adds an entity to the data if there is room for it
        {
            if (rabbits.Count + 1 <= this.Capacity)
            {
                rabbits.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)   //removes a rabbit by given name, if such exists, and returns bool 
        {
            foreach (var rab in rabbits)
            {
                if (rab.Name == name)
                {
                    rabbits.Remove(rab);
                    Console.WriteLine("true");
                    return true;
                }
            }
            return false;
        }

        public void RemoveSpecies(string species)
        {
            foreach (var rab in rabbits)
            {
                if (rab.Species == species)
                {
                    rabbits.Remove(rab);
                }
            }
        }

        public Rabbit SellRabbit(string name)
        {
            Rabbit notReturn = rabbits[0];
            foreach (var rab in rabbits)
            {
                if (rab.Name == name)
                {
                    rab.Available = false;
                    return rab;
                }
            }
            return notReturn;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            List<Rabbit> rabList = new List<Rabbit>();

            foreach (var rab in rabbits)
            {
                if (rab.Species == species)
                {
                    rab.Available = false;
                    rabList.Add(rab);
                }
            }

            return rabList.ToArray();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {this.Name}:");
            foreach (var rab in rabbits)
            {
                if (rab.Available == true)
                {
                    sb.AppendLine(rab.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
