using System;

namespace TowersOfHanoi
{
   public class Program
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine("Please enter the number of disks: ");
            int disks = int.Parse(Console.ReadLine());
            Tower(disks, "A", "B", "C");
        }

            public static void Tower(int n, string startRod, string auxiliaryRod, string endRod)
            {
                if (n == 1)
                {
                    Console.WriteLine(startRod + " -> " + endRod);
                }
				else if (n < 1)
				{
					Console.WriteLine("Error. Please enter valid number of disks.");
				}
                else
                {
                    Tower(n-1, startRod, endRod, auxiliaryRod);
                    Console.Write(startRod + " -> " + endRod);
                    Tower(n-1, auxiliaryRod, startRod, endRod);
                }
            }
    }
}



