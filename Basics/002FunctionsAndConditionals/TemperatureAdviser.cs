using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Please enter the current temperature in Celsius: ");
		float temp = float.Parse(Console.ReadLine());
		
		if(temp > 30){
			Console.WriteLine("Please stay hydrated and avoid staying in the sun for too long!");
		} else {
			Console.WriteLine("Go out and enjoy the pleasant weather!");
		}
	}
}