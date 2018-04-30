using System;
using System.Threading;

namespace DataType
{
    public class Program
    {

    public static void Main(string[] args)
    {
        string stick = "";
        string spider = "";
        string fight = "";
        string restart = "";

        Console.WriteLine("{0, 65}", "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("{0, 65}", "Welcome to the cavern of secrets!");
        Console.WriteLine("{0, 65}", "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Thread.Sleep(3000); //Pause

        Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");

        Console.WriteLine("Do you take it? [Y/N]: ");
        stick = Console.ReadLine();

        //STICK TAKEN.
        bool taken;

        if(stick == "y" || stick == "Y" || stick == "yes" || stick == "YES" || stick == "Yes")
        {
            Console.WriteLine(value: "You have taken the stick!");
            taken = true;
        }

        //STICK NOT TAKEN
        else
        {
            Console.WriteLine("You did not take the stick.");
            taken = false;
        }
        Thread.Sleep(2000); //Pause

        Console.WriteLine("As you proceed further into the cave, you see a small glowing object.");
        Console.WriteLine("Do you approach the object? [Y/N]");

        spider = Console.ReadLine();

        //APPROACH SPIDER
        bool approach;

        if(spider == "y" || spider == "Y" || spider == "yes" || spider == "YES" || spider == "Yes")
        {
            Console.WriteLine("You approach the object...");
            approach = true;
            Thread.Sleep(2000); //Pause

            Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");
            Console.WriteLine("The eye belongs to a giant spider!");
            Thread.Sleep(2000); //Pause

            Console.WriteLine("Do you try to fight it? [Y/N]");

            fight = Console.ReadLine();

            //FIGHT SPIDER
            bool fighting;

            if(fight == "y" || fight == "Y" || fight == "yes" || fight == "YES" || fight == "Yes")
            {
            //FIGHT SPIDER WITH STICK
                if(taken)
                {
            Console.WriteLine("You only have a stick to fight with!");
            Thread.Sleep(2000); //Pause
            Console.WriteLine("You quickly jab the spider in it's eye and gain an advantage");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("                  Fighting...                   ");
            Console.WriteLine("   YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER    ");
            Console.WriteLine("IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Thread.Sleep(3000); //Pause
            Console.WriteLine("You have died!");

            Thread.Sleep(2000); //Pause

            Console.WriteLine("Would you like to play again? [Y/N]: ");
            restart = Console.ReadLine();

            bool newGame;
                if(restart == "y" || restart == "Y" || restart == "yes" || restart == "YES" || restart == "Yes")
                {
                    Console.WriteLine("Don't even try. You will die if you have not died yet!");
                    newGame = true;
                    Environment.Exit(0);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("You made a good decision. You will die anyway!");
                    newGame = false;
                    Environment.Exit(0);
                    Console.WriteLine();
                }

            Environment.Exit(0);

               }

             //FIGHT SPIDER WITHOUT STICK
             else
               {
            Console.WriteLine("You don't have anything to fight with!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("                  Fighting...                   ");
            Console.WriteLine("   YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER    ");
            Console.WriteLine("IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Thread.Sleep(2000); //Pause

            Console.WriteLine("Go home!");
            Environment.Exit(0);
            Console.WriteLine();

            Thread.Sleep(2000); //Pause
              }
                fighting = true;
            }

              //DON'T FIGHT SPIDER
            else
            {
                Console.WriteLine("You choose not to fight the spider.");

                Thread.Sleep(2000); //Pause
                Console.WriteLine("As you turn away, it ambushes you and impales you with it's fangs!!!");

                fighting = false;

               Thread.Sleep(2000); //Pause

                Console.WriteLine("You managed to escape the cavern alive! Would you like to play again? [Y/N]: ");
                restart = Console.ReadLine();
                bool newGame;

                if(restart == "y" || restart == "Y" || restart == "yes" || restart == "YES" || restart == "Yes")
                {   Console.WriteLine("Not today, not today.");
                    newGame = true;
                }
                else
                {
                    Console.WriteLine("Don't even try. You have died!");
                    newGame = false;
                }
            }
        }
        // DON'T APPROACH SPIDER
        else
        {
            Console.WriteLine("You turn away from the glowing object, and attempt to leave the cave...");

            Thread.Sleep(2000); //Pause
            Console.WriteLine("But something won't let you....");
            approach = false;

           Thread.Sleep(2000); //Pause

           Console.WriteLine("You managed to escape the cavern alive!");
           Console.WriteLine("Would you like to play again? [Y/N]: ");
           restart = Console.ReadLine();

            bool newGame;
                if(restart == "y" || restart == "Y" || restart == "yes" || restart == "YES" || restart == "Yes")
                {
                    Console.WriteLine("Don't even try. You will die if you have not died yet!");
                    newGame = true;
                    Environment.Exit(0);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("You made a good decision. You will die anyway!");
                    newGame = false;
                    Environment.Exit(0);
                    Console.WriteLine();
                }
        }
     }
   }
}
