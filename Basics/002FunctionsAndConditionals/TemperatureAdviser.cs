using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Please enter the current temperature in Celsius: ");
		float temp = float.Parse(Console.ReadLine());
		
		if(temp > 30){
			Console.WriteLine("Please stay hydrated and avoid staying in the sun for too long!");
		} else if (temp > 20){
			Console.WriteLine("Go out and enjoy the pleasant weather!");
		} else if (temp > 10){
			Console.WriteLine("I recommend wearly a light jacket today.");
		} else {
			Console.WriteLine("Don't forget your booties cuz it's COLD out there today! It's cold out there everyday. What is this, Miami Beach? Not hardly.");
		}
	}
}