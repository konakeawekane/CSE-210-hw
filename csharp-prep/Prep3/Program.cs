using System;

class Program
{
    static void Main(string[] args)
    {
        Random RNG = new Random();
        int magicNumber = RNG.Next(1, 100);
        int answer;
        String submition = "";

        Console.Write("What is the Magic Number? ");
        submition = Console.ReadLine();
        answer = int.Parse(submition);
        while (!(answer == magicNumber))
        {
            if (answer < magicNumber) { Console.WriteLine("Higher"); }
            if (answer > magicNumber) { Console.WriteLine("Lower"); }

            Console.Write("What is your guess? ");
            submition = Console.ReadLine();
            answer = int.Parse(submition);
        }

        Console.WriteLine("You guessed it!");
    }
}