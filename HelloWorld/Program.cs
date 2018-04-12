using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Everyone!");
            Console.WriteLine("I'm Nina.");

            string name = "";

            Console.WriteLine("What is your name? ");
            name = Console.ReadLine();

            Console.WriteLine("Hi {0}! Nice to meet you!", name);
        }
    }
}
