using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment a1 = new MathAssignment("7.2", "4-9", "Tim", "Fractions");

        System.Console.WriteLine(a1.GetSummery());
        System.Console.WriteLine(a1.GetHomeworkList());

        WritingAssignment a2 = new WritingAssignment("WWII history dissertation", "Bob", "History Lit");

        System.Console.WriteLine(a2.GetSummery());
        System.Console.WriteLine(a2.GetWritingInformation());
    }
}