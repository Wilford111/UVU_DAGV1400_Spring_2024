using System;
					
public class Program
{
	public static void Main()
	{
        //variables:
		int a = 10; //an "int" is an integer. They are used if you want a whole number.
		int b = 5;
		float c = 1.2F; //a float is a number with a decimal value. They are used if you want a precise number value.
		double d = 2.555D; //a double is a decimal value number, but it can hold more data than a float.
		string complaint = "I had to redo this section lol."; //a string is a value that has a line of text. It can be used to communicate to the user and/or terminal.
		char izard = 'C'; //a character is a value that only contains one character. It can be a letter or a number.

		//writing the variables in the terminal:
		Console.WriteLine(a);
		Console.WriteLine(b);
		Console.WriteLine(c);
		Console.WriteLine(d);
		Console.WriteLine(complaint);
        Console.WriteLine(izard);
	}
}