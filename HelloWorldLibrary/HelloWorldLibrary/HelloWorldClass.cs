using System;

namespace HelloWorldLibrary
{
    public class HelloWorldClass
    {
        public static string SayHello(string name)
        {
            var timeNow = DateTime.Now.ToString("hh:mm tt");
            return $"{timeNow} Hello, {name}!";
        }
    }
}
