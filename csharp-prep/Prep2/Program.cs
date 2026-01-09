using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade persentage: ");
        string input = Console.ReadLine();
        float persentage = float.Parse(input);
        int firstDigit = ((int)persentage) % 10;
        string sign = "";
        string letter = "";

        if(persentage < 60.0)
        {
            letter = "F";
        } else if(persentage < 70.0)
        {
            letter = "D";
        } else if(persentage < 80.0)
        {
            letter = "C";
        } else if(persentage < 90.0)
        {
            letter = "B";
        } else if(persentage >= 90.0)
        {
            letter = "A";
        }

        if(firstDigit > 7 && !(letter == "A" || letter == "F"))
        {
            sign = "+";
        } else if(firstDigit < 3 && !(letter == "F"))
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (persentage >= 70.0)
        {
            Console.WriteLine("Congradulations you passed!");
        } else
        {
            Console.WriteLine("You have not passed. Try again next time!");
        }
    }
}