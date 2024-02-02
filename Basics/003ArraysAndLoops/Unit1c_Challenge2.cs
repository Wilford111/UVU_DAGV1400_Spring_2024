using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter your three favorite foods:");
        string food1 = Console.ReadLine();
        string food2 = Console.ReadLine();
        string food3 = Console.ReadLine();
        
        string[] foodList = {food1, food2, food3};
        //Store each of the user's inputs inside the array "foodList".
        
        foreach(string i in foodList){
            Console.WriteLine("I love " + i + "!");
        }
    }
}