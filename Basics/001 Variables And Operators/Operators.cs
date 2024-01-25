//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

using System;
					
public class Program
{
	public static void Main()
	{
		//variables:
		int a = 10; //an "int" is an integer. They are used if you want a whole number.
		int b = 5;
		float c = 1.2F; //a float is a number with a decimal value. They are used if you want a precise number value.
		double d = 2.555D; //a double is a decimal value number, but it can hole more data than a float.
		string complaint = "I had to redo this section lol."; //a string is a value that has a line of text. It can be used to communicate to the user and/or terminal.
		
		//writing the variables in the terminal:
		Console.WriteLine(a);
		Console.WriteLine(b);
		Console.WriteLine(c);
		Console.WriteLine(d);
		Console.WriteLine(complaint);
		
		Console.WriteLine(""); //just using this WriteLine function to separate variables from operators.
		
		//modifying these variables with operators:
		Console.WriteLine(a + b); //you can modify these variables directly within a WriteLine command,
		
		int simpleOperation = a + b;
		Console.WriteLine(simpleOperation); //or you can create a new variable by combining two other variables.
		
		//more examples of operations:
		Console.WriteLine(b-a); //subtraction
		Console.WriteLine(a*b); //multiplication
		Console.WriteLine(a/b); //division
		Console.WriteLine(a+=1); //adding 1 to an existing variable.
		
		bool trueBoolean = a>b; //creating a boolean variable with a value of True.
		Console.WriteLine(trueBoolean);
		
		bool falseBoolean = a<b; //creating a boolean variable with a value of False.
		Console.WriteLine(falseBoolean);
	}
}