using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Everyone!");
            Console.WriteLine("I'm Nina.");

            string name = "";
            int age = 0;
            string gender = "";
            int siblings = 0;
            int children = 0;
            string music = "";
            string song = "";
            string movie = "";
            string actor = "";
            string food = "";
            string vacation = "";
            string dream = "";


            Console.WriteLine("What is your name? ");
            name = Console.ReadLine();

            Console.WriteLine("I like your name, {0}. Nice to meet you here!", name);

            Console.WriteLine("How old are you, {0}?", name);
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("So, your name is {0} and you are {1} years old.", name, age);

            Console.WriteLine("What is your gender, {0} - male or female?", name);
            gender = Console.ReadLine();

            Console.WriteLine("How many siblings do you have if any, {0}?", name);
            siblings = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you have any children, {0}? If yes, how many?", name);
            children = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What kind of music do you like to listen to that affect your perceptions and emotions, {0}?", name);
            music = Console.ReadLine();

            Console.WriteLine("Is there any favorite song that you can't stop listening to, {0}?", name);
            song = Console.ReadLine();

            Console.WriteLine("Out of all the movies you have ever seen, which is your most favorite?");
            movie = Console.ReadLine();

            Console.WriteLine("Who is your most favorite movie celebrity living today?");
            actor = Console.ReadLine();

            Console.WriteLine("What is your favorite food in the world?");
            food = Console.ReadLine();

            Console.WriteLine("Where is your favorite vacation destination?");
            vacation = Console.ReadLine();

            Console.WriteLine("What dream destinations are on your bucket list?");
            dream = Console.ReadLine();


            Console.WriteLine("So, let me summarize what you have just said, {0}.", name);
            Console.WriteLine("You are {0} years old {1} with {2} child/chilren and {3} siblings.", age, gender, children, siblings);
            Console.WriteLine("There is a {0} music that affect your mood. And your favorite song is {1}.", music, song);
            Console.WriteLine("{0}'s favorite movie is {1} and {2} is the favorite movie celebrity living today.", name, movie, actor);
            Console.WriteLine("Without question, {0} likes to eat {1}. What could be better?", name, food);
            Console.WriteLine("Also, {0}'s favorite vacation is {1} and the dream destination is {2}.", name, vacation, dream);

            Console.WriteLine("Thank you for kindly participating in this questionnaire, {0}.", name);

        }
    }
}