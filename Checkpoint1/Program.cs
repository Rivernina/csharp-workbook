using System;
using System.Linq;
using System.Collections.Generic;

namespace Checkpoint1
{
					
public class Program
{
	public static void Main()
	{
		Checkpoint1_1();
		Checkpoint1_2();
		Checkpoint1_3();
		Checkpoint1_4();
		Checkpoint1_5();
	}
		
	
	
		// 1.1 Write a program to count how many numbers between 1 and 100 are 
		// divisible by 3 with no remainder. Display the count on the console.
		
		public static void Checkpoint1_1()
		{
			Console.WriteLine("{0,50}", "*********** Checkpoint 1.1 ************");
		
			int total = 0;
			for (int i = 1; i <= 100; i++)		
			if 	(i % 3 == 0)
			{
				Console.WriteLine(i);
				total++;
			}
			{
				Console.WriteLine("There are {0} numbers between 1 and 100 that are divisible by 3 with no remainder.\n", total);
			}
	
		}		
		
	
	
		
		//1.2 Write a program and continuously ask the user to enter a number 
		// or "ok" to exit. Calculate the sum of all the previously entered
		// numbers and display it on the console.
	
		public static void Checkpoint1_2()
		{
			Console.WriteLine("{0,50}", "*********** Checkpoint 1.2 ************\n");
		
			bool exit = true;
			long sum = 0;  
        	         
        	Console.WriteLine("Please enter a number and I will calculate the SUM of all entered numbers.\n");
        	Console.WriteLine("Or enter OK to exit");

            while(exit)
            {
            	string i = Console.ReadLine().ToLower();
              	if ( i == "ok")
                {
					Console.WriteLine("---------- That is all! ------------\n"); 
                    exit = false;
                    break;
                }
				
            	sum += Convert.ToInt64(i);
            	Console.WriteLine("\n\tThe Sum of all entered numbers is {0}.\n", sum);            
             } 
		}
		
		
	
	
		//1.3 Write a program and ask the user to enter a number. 
		//Compute the factorial of the number and print it on the console. 
		//For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
		//and display it as 5! = 120.
	
		public static void Checkpoint1_3()
		{
			Console.WriteLine("{0,50}", "*********** Checkpoint 1.3 ************\n");
		
		
			Console.WriteLine("Please enter your factorial number between 1 and 100 = ");
		
        	double factorial = double.Parse(Console.ReadLine());
        	double result = 1;
 
        	while (true)
        	{
        		Console.Write(factorial);
            	if (factorial == 1)
            	{
             		break;
          		}
				
            Console.Write(" * ");
            result *= factorial;
            factorial--;
				
       		}
		
        	Console.WriteLine(" = {0}", result);
			Console.WriteLine("Factorial of your number! = {0}.\n", result);
		}
		
	

  	
		// 1.4 Write a program that picks a random number between 1 and 10. 
		// Give the user 4 chances to guess the number. 
		// If the user guesses the number, display “You won"; otherwise, display “You lost". 
		// (To make sure the program is behaving correctly, you can 
		// display the secret number on the console first.)	
	
		public static void Checkpoint1_4()
		{
			Console.WriteLine("{0,50}", "*********** Checkpoint 1.4 ************\n");
			
			
			Console.WriteLine("Please enter a number between 1 and 10.");
			Console.WriteLine("You have 4 chances to guess the secret number.");
			
			int randomInteger = Getting_Random();
		    Attempts(randomInteger);
		}
	
		private static int Getting_Random()
		{
			var random = new Random();
			return random.Next(1, 10);
		}

	  	 public static void Attempts(int randomInteger)
			{
				for (int i = 1; i <= 4; i++)
            	{
				
					Console.Write("\n\tThe {0} attempt: ", i);
					int input = int.Parse(Console.ReadLine());
					//Console.WriteLine("You have entered the number: {0}", input); 
				
					if (input == randomInteger ) 
					{
						Console.WriteLine("\t\nYou have won! The secret number is {0}.\n", randomInteger);
						break;
					}
				
					if (ChancesToWin(i))
					{
						Console.WriteLine("You lost. The secret number was {0}.", randomInteger);	
						break;
					}
				
					Console.Write("Nope. Try again.\n");
				
				}
			}
			
		 private static bool ChancesToWin(int i)
		 {
			return i == 4;			
		 }
	
	
	

        // 1.5 Write a program and ask the user to enter a series of numbers 
	    // separated by comma. Find the maximum of the numbers and  
	    // display it on the console. For example, if the user enters 
		//“5, 3, 8, 1, 4", the program should display 8.
	
		public static void Checkpoint1_5()
		{
			Console.WriteLine("\n{0,50}", "*********** Checkpoint 1.5 ************\n");
			
			Console.WriteLine("Enter a numbers separated by a space:");

		int greatest = 0;
		string[] bunchOfNumbers = Console.ReadLine().Split(' ');
		int[] nums = Array.ConvertAll(bunchOfNumbers, int.Parse);

		foreach (int num in nums)
		{
			if (num > greatest)
			{
				 greatest = num;
			}
		}
		Console.WriteLine("{0} - is the greatest number.", greatest);	
		Console.WriteLine("\n\t\t************Thanks!************\n");
		}
	
	}
}
		
