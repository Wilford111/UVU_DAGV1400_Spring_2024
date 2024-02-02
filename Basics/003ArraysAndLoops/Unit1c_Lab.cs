using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Please enter a number: ");
		int input = Int32.Parse(Console.ReadLine());
		int column = 1;
		
		for(var i = 1;input >= i; i++){
			for(var c = 1;column >= c; c++)
				Console.Write(column);
				column++;
			Console.WriteLine("");
		}
	}
}