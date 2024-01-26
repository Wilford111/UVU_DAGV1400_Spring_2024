using System;

public class Program
{

    public void Main()
    {
        int gradeInt = Int32.Parse(Console.ReadLine()); //Created an integer variable called gradeInt, which is equal to an integer-converted user input.
		
		if(gradeInt >= 90){
			Console.WriteLine("You got an A. Congratulations!");
		} else if(gradeInt >= 80) {
			Console.WriteLine("You got a B. Good work!");
		} else if(gradeInt >= 70) {
			Console.WriteLine("You got a C. You made it!");
		} else if(gradeInt >= 60) {
			Console.WriteLine("You got a D. There's some room for improvement!");
		} else 
			Console.WriteLine("You got an F. Please spend more time studying!");
    }
}