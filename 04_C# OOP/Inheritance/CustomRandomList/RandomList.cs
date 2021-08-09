using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {

        public string RandomString()
        {
            Random random = new Random();

            string current = this[random.Next(0, this.Count)];
            this.Remove(current);
            return current;
        }
    }
}
