using System;

public class Program
{
	public ClassInSchool studentStudies;
	
    public void Main()
    {
		Console.WriteLine("Enter your grade:");
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
		
		Console.WriteLine(""); //Created a space in between the grade and class subject.
		Console.WriteLine("Enter your class subject:");
		
		studentStudies = new ClassInSchool(); //starting the function from ClassInSchool.
		studentStudies.ClassSubject(); //Running the function.
    }
}

public class ClassInSchool
{
	public string subjectChoice = Console.ReadLine(); //Creating a variable from user input called subjectChoice
	
	public void ClassSubject()
	{
		switch(subjectChoice){ //creating a case depending on what the user typed.
			case "History":
				Console.WriteLine("It's great to learn about everything that brought us to this moment!");
				break;
			case "English":
				Console.WriteLine("Communication with others is what makes us human, some might say.");
				break;
			case "Math":
				Console.WriteLine("Math is in everything. Learning more about it will lead you to success.");
				break;
			case "Art":
				Console.WriteLine("Expressing yourself is what some people live for.");
				break;
			case "SocialStudies":
				Console.WriteLine("Learning about other cultures will help you appreciate your own.");
				break;
			case "Economics":
				Console.WriteLine("Save them pennies, eh.");
				break;
			case "Science":
				Console.WriteLine("Science teaches us about how the world works, in a literal sense.");
				break;
			default:
				Console.WriteLine("Choose another subject!");
				break;
		}
	}
	
}