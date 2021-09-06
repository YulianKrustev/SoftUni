using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowseable
    {
        public void Browsing(string address)
        {
            Console.WriteLine($"Browsing: {address}!");
        }

        public void Calling(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }
    }
}
