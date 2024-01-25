//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

using System;
					
public class Program
{
	public static void Main()
	{
		//variables:
		int a = 10;
		int b = 5;
		float c = 1.2F;
		double d = 2.555D;
		string complaint = "I had to redo this section lol.";
		
		//writing the variables in the terminal:
		Console.WriteLine(a);
		Console.WriteLine(b);
		Console.WriteLine(c);
		Console.WriteLine(d);
		Console.WriteLine(complaint);
		
		Console.WriteLine("");
		
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