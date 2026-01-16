using System;
using System.IO.Pipelines;

class Program
{
    static void Main(string[] args)
    {
        int birthYear;
        DisplayWelcome();
        String name = PromptUserName();
        int number = PromptUserNumber();
        PromtUserBirthYear(out birthYear);
        number = SquareNumber(number);
        DisplayResult(name, number, birthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static String PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static void PromtUserBirthYear(out int year)
    {
        Console.Write("Please enter your birth year: ");
        year = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(String name, int number, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
        Console.WriteLine($"{name}, you will turn {DateTime.Now.Year - birthYear} this year.");
    }

}