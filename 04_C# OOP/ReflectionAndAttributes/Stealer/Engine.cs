using System;
using System.Reflection;


    public class Engine
    {
        public void Run()
        {
            Spy spy = new Spy();
            string result = spy.StealFieldInfo("Hacker", "username", "password");
            Console.WriteLine(result);
        }
    }