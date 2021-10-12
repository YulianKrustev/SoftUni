using System;

namespace Stealer
{
    public class Engine
    {
        public void Run()
        {
            Spy spy = new Spy();
            string result = spy.RevealPrivateMethods("Stealer.Hacker");
            Console.WriteLine(result);
        }
    }
}