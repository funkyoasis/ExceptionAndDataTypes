using System;
using System.IO;

namespace ExceptionsApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string text;
			string fileName = "HelloWorld.txt";
			try
			{
				Console.WriteLine("Anil's mark is 82: " + Grade(82));
				Console.WriteLine("Cathy's mark is -23: " + Grade(-23));
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("Invalid data, please try again");
				Console.WriteLine(e.Message);
			}

			try
			{
				text = File.ReadAllText(fileName);
				Console.WriteLine(text);
			}
			catch (FileNotFoundException e)
			{
				Console.WriteLine("Sorry I can't find: " + fileName);
			}
			catch (ArgumentException e)
			{
				Console.WriteLine("You gave me an empty file name -" + e.Message) ;
			}
			finally
			{
				Console.WriteLine("We made it here!");
			}
		}
		public static string Grade(int mark)
		{
			if (mark < 0 || mark > 100) 
			{
				throw new ArgumentOutOfRangeException("Mark: " + "Allowed range 0-100");
			}
			return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
		}
	}
	
}
