// The Expectation is that you write your own code based
// on what you have learned in the class, it can be what you want
// If you are havind trouble thinging of something, write conditionals
// with the topic of PowerUps, what happens if the powerUp is good or bad.

using System;

public class Program
{
	public OSControl userDecision;
	
    public void Main()
	{
		userDecision = new OSControl();
		
		userDecision.userOS = OSControl.OS.Linux;
		userDecision.CheckOS();
	}
}

public class OSControl {
	public enum OS {
		Windows,
		Mac,
		Linux
	}
	
	public OS userOS = OS.Windows; //This is to default enum OS to the first option, so that nothing unexpected happens later.
	
	public void CheckOS(){
		switch(userOS){
			case OS.Windows:
				Console.WriteLine("That's an okay choice, I mean it's a little mainstream but eh.");
				break;
			case OS.Mac:
				Console.WriteLine("Go and repent of your sins.");
				break;
			case OS.Linux:
				Console.WriteLine("Okay that's based, you're in.");
				break;
			default:
				Console.WriteLine("Huh, I've never heard of that one.");
				break;
		}
	}
}