using System;

namespace FizzBuzz 
{
                    
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n{0,50}", "*****************************************");
            Console.WriteLine("");
            Console.WriteLine("{0,41}", "Welcome to FizzBuzz!");
            Console.WriteLine("");

            Console.WriteLine("{0,50}", "*****************************************");
            Console.WriteLine(""); 
            Console.WriteLine("");
     
    
            for (int i = 0; i <= 50; i++)		
            if 	(i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
