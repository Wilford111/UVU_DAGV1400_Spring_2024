using System;

public class Program
{
    public void Main()
    {

    }
}

public class Grade
{
    string gradeInput = Readline();
    int gradeInt = Int32.parse(gradeInput)
    public void GradeInputFn()
    {
        if(gradeInt > 90){
            Console.WriteLine("You got an A. Congratulations! Keep up the good work.");
        }
    }
}