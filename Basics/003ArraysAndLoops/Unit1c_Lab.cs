using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Please enter a number: ");
		int input = Int32.Parse(Console.ReadLine());
		int column = 1;
		
		for(var i = 1;input >= i; i++){
            //for every time input is greater than or equal to i...
			for(var c = 1;column >= c; c++)
                //for every time column is greater than or equal to c...
				Console.Write(column);
                //print the value of column
				column++;
                //increase the value of column by 1
			Console.WriteLine("");
            //print a new line
		}
	}
}