using System;
using System.Reflection;

namespace Stealer
{
    public class Engine
    {
        public void Run()
        {
            Spy spy = new Spy();
            string result = spy.StealFieldInfo("Stealer.Hacker", "username", "password");
            Console.WriteLine(result);
        }
    }
}