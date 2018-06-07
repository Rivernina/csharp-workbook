using System;

namespace FizzBuzz 
{
					
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("{0,70}", "*****************************************");
			Console.WriteLine("\t\t\t\t\t\t\t *   \t\t\t\t\t\t\t\t\t*");
			Console.WriteLine("\t\t\t\t\t\t\t *{0,34}",  "Welcome to FizzBuzz! \t\t *");
			Console.WriteLine("\t\t\t\t\t\t\t *   \t\t\t\t\t\t\t\t\t*");

			Console.WriteLine("{0,70}", "*****************************************");
			Console.WriteLine("");
			Console.WriteLine("");
	 
	
        	for (int i = 0; i < 100; i++)		
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
