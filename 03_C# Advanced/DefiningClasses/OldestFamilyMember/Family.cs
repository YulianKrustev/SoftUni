using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        List<Person> family;

        public Family()
        {
            this.family = new List<Person>();
        }
        public void AddMember(Person person)
        {
            this.family.Add(person);
        }

        public Person GetOlderMember()
        {
            return family.OrderByDescending(x => x.Age).First();
        }
    }
}
