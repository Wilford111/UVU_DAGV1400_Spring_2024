//For whatever reason, this code is very janky and doesn't work quite right in dotnetfiddle.
//However, it works perfectly fine on programiz's online C# compiler.

using System;

public class Program
{	
	public static void Main()
	{
		Random rdm = new Random();
		int rNum = rdm.Next(1,10);
		
		Console.Write("A random number has been generated between 1 and 10! See if you can guess what it is... ");
		int gNum = Int32.Parse(Console.ReadLine());
		int attempts = 1;
		
		while(gNum != rNum){
			if(gNum > rNum){
				Console.Write("Too high! ");
				gNum = Int32.Parse(Console.ReadLine());
				attempts++;
			}else if(gNum < rNum){
				Console.Write("Too Low! ");
				gNum = Int32.Parse(Console.ReadLine());
				attempts++;
			}else{
				break;
			}
		}
		Console.WriteLine("Congrats, you guessed right! Attempts made: " + attempts);
	}
}