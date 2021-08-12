using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public int Age { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
