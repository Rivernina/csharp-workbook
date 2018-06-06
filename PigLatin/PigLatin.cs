using System;

namespace PigLatin
{

public class Program
		{
		public static void Main()
				{
						Console.WriteLine("{0,70}", "*****************************************");
						Console.WriteLine("");
						Console.WriteLine("{0,65}", "Welcome to PigLatin translation!");
						Console.WriteLine("");

						Console.WriteLine("{0,70}", "*****************************************");
						Console.WriteLine("");
						Console.WriteLine("");



						Console.WriteLine("Enter a word or phrase that you would like to translate into PigLatin:");

						string input = Console.ReadLine();

						string[] phrase = input.Split(' ');

						foreach (string word in phrase)
						{
								Console.WriteLine(TranslateToPig(word));
						}

						Console.ReadLine();
						Environment.Exit(0);

				}

		public static string TranslateToPig(string word)
				{
						word = word.ToLower();
						int firstVowelIndex = word.IndexOfAny(new char[] {'e', 'a', 'i', 'o', 'u', 'y'});
						//Console.WriteLine(firstVowelIndex.ToString());

						if (firstVowelIndex <= 0)
						{
								return word + "yay";
						}
						else
						{
						string firstPart = word.Substring(0, firstVowelIndex);
						string secondPart = word.Substring(firstVowelIndex);

						return secondPart + firstPart + "ay";
						}
				}
		}
}