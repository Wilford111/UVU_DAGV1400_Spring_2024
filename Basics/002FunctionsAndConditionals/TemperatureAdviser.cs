using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Please enter the current temperature in Celsius: ");
		float temp = float.Parse(Console.ReadLine()); //This creates a float variable from the user input.
		
		if(temp > 30){ //If the temperature is above 30 degrees Celcius
			Console.WriteLine("Please stay hydrated and avoid staying in the sun for too long!");
		} else if (temp > 20){ //If the temperature is above 20 degrees Celcius
			Console.WriteLine("Go out and enjoy the pleasant weather!");
		} else if (temp > 10){ //If the temperature is above 10 degrees Celcius
			Console.WriteLine("I recommend wearly a light jacket today.");
		} else { //This is for anything below 10 degrees Celcius
			Console.WriteLine("Don't forget your booties cuz it's COLD out there today! It's cold out there everyday. What is this, Miami Beach? Not hardly.");
		}
	}
}