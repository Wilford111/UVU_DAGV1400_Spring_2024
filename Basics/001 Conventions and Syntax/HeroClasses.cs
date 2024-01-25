//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero heroThree;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		heroThree = new Hero();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		heroOne.defense = 5;
		heroOne.height = 1.83F;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		heroTwo.defense = 8;
		heroTwo.height = 1.65F;

		heroThree.health = 2;
		heroThree.powerLevel = 10;
		heroThree.defense = 3;
		heroThree.height = 2.0F;
		
		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.powerLevel);
		Console.WriteLine(heroOne.defense);
		Console.WriteLine(heroOne.height);
		
		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.powerLevel);
		Console.WriteLine(heroTwo.defense);
		Console.WriteLine(heroTwo.height);

		Console.WriteLine(heroThree.health);
		Console.WriteLine(heroThree.powerLevel);
		Console.WriteLine(heroThree.defense);
		Console.WriteLine(heroThree.height);
	}
}

public class Hero {
	public int health;
	public int powerLevel;
	public int defense;
	public float height;
}