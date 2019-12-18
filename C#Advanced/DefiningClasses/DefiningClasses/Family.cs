using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> family = new List<Person>();


        public void AddMember(Person person)
        {
            family.Add(person);
        }

        public Person GetOldestMember() 
            => family.OrderByDescending(x => x.Age).FirstOrDefault();
    }
}
