/* 
The following code is free code void of copyright,
it's purpose is obtaining the average in a series of numbers
 */
using System;
public class Average
{
	public static void Main()
	{
		double sum = 0, note = 0, counter = 0, average = 0;
		string mark = " ";

		Console.Write("Insert a mark (\"end\" to finish): ");
		mark = Console.ReadLine();
		
		while(mark != "end")
		{
			/* This part can crash the application, it could be improved by adding 
				error control methods to the string to double conversion */
			note = Convert.ToDouble(mark);
			counter++;
			sum += note;
			Console.Write("Insert a mark (\"end\" to finish): ");
			mark = Console.ReadLine();
		}
		
		if(counter != 0)
		{
		average = sum / counter;
		Console.WriteLine("The average is {0}.", average);
		}
	}
}
