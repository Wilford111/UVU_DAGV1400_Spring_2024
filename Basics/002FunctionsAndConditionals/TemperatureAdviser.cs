using System;
					
public class Program
{
	public StoredVariable openedVariable;
	
	public void Main()
	{
		openedVariable = new StoredVariable();
		
		Console.WriteLine("Please enter the current temperature in Celsius: ");
		openedVariable.tempInt = Console.ReadLine();
		
		int temp = Int32.Parse(openedVariable.tempInt);
		
//		try
//		{
//			int temp = Int32.Parse(openedVariable.tempInt);
//		} catch (FormatException) {
//			Console.WriteLine("Please enter a numeric value.");
//		}
		
		if(temp > 30){
			Console.WriteLine("Please stay hydrated and avoid staying in the sun for too long!");
		} else {
			Console.WriteLine("Go out and enjoy the pleasant weather!");
		}
	}
}

public class StoredVariable
{
	public string tempInt; 
	
}