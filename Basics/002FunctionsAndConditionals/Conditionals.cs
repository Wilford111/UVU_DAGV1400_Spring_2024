using System;

public class Program
{
    public IfClass ifClassVar;

    public void Main()
    {
        ifClassVar = new IfClass();
        Console.WriteLine("Hello World!");

        ifClassVar.IfFunction(9); //inputing 9 into the variable
		ifClassVar.IfFunction(11); //inputing 11 into the variable
    }
}

public class IfClass
{
    public void IfFunction(int value1){
        if(value1 > 10){ //Checking to see if the variable is greater than 10
            Console.WriteLine("Value1 is greater than 10.");
        } else if(value1 == 10){ //Checking to see if the variable is equal to 10
            Console.WriteLine("Value1 is equal to 10.");
        } else Console.WriteLine("Value1 is less than 10."); //The only other outcome is that the variable is less than 10
    }
}