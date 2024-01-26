using System;

public class Program
{
    public SwitchClass switchClassVar;

    public void Main()
    {
        switchClassVar = new SwitchClass();
        Console.WriteLine("Hello World!");

        switchClassVar.SwitchFunction(9);
		switchClassVar.SwitchFunction(11);
    }
}

public class SwitchClass
{
    public void SwitchFunction(int value1){
        switch(value1 >= 10){
            case(true):
            	Console.WriteLine("Value1 is 10 or greater.");
            	break;
			default:
				Console.WriteLine("Value1 is less than 10.");
				break;
        }
    }
}