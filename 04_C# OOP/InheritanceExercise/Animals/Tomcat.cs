using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        private const string gender = "Male";
        public Tomcat(string name, int age, string gender = "Male") : base(name, age, gender)
        {
            this.Gender = gender;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("MEOW");
        }
    }
}
