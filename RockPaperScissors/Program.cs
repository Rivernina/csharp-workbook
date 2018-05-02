using System;

namespace RockPaperScissors
{
   public class Program
    {
      public static int hand1Score = 0; 
     
      public static int hand2Score = 0;
     
      public static void Main()
        {
       
         Console.WriteLine("{0,50}", "*****************************************");
         Console.WriteLine("");
         Console.WriteLine("{0,47}", "Welcome to Rock-Paper-Scissors game!");
         Console.WriteLine("");

         Console.WriteLine("{0,50}", "*****************************************");
         Console.WriteLine(""); 
         Console.WriteLine("");

         string[] plays = new string[] {"rock", "paper", "scissors"};    
         
         while (hand1Score < 5 && hand2Score < 5)
         {
          Console.Write("Enter Hand 1: ");
          string hand1 = Console.ReadLine().ToLower();

          //Console.Write("Enter Hand 2: ");
          // string hand2 = Console.ReadLine().ToLower();
          Random rnd = new Random();
          int randomInteger = rnd.Next(0, 3);
          string hand2 = plays[randomInteger];
          Console.WriteLine("Hand 1 played {0} and Hand 2 played {1}.", hand1, hand2);
          Console.WriteLine(CompareHands(hand1, hand2));
          Console.WriteLine("Hand 1 has {0} points and Hand 2 has {1} points\n", hand1Score, hand2Score);
        }

        if(hand1Score == 5 || hand2Score == 5)
			{
				Console.WriteLine("\n\t*****Thank you for playing with me!*****\n".ToUpper());
			}
        
      }

      public static string CompareHands(string hand1, string hand2)
        {
            // Your code here
            //return hand1 + '\t' + hand2;
          if (hand1 == hand2)
          {
            return "\tIt's a tie!\n";
          }
      
          if (hand1 == "rock")
          {
            if (hand2 == "paper")
          {
            hand2Score++;
            return "\tHand 2 Wins!\n".ToUpper();
        }
          hand1Score++;
          return "\tHand 1 Wins!\n".ToUpper();
        }
      
        if (hand1 == "scissors")
        {
          if (hand2 == "paper")
          {
            hand1Score++;
            return "\tHand 1 Wins!\n".ToUpper();
          }
          hand2Score++;
          return "\tHand  2 Wins!\n".ToUpper();
        }
      
        if (hand1 == "paper")
        {
          if (hand2 == "scissors")
          {
            hand2Score++;
            return "\tHand 2 Wins!\n".ToUpper();
          }
          hand1Score++;
          return "\tHand  1 Wins!\n".ToUpper();
        }
      
        return "\tNot valid hand! Please try again.\n";	
      }
      
  }
}