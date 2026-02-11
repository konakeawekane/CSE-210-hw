using System;

class Program
{
    static void Main(string[] args)
    {
        Referance referance1 = new Referance("John", 3, 16, 17);

        //constructor automatically splits string into words
        Scripture scripture1 = new Scripture(referance1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved");

        bool running = true;
        string input;

        while (running)
        {   
            Console.Clear();
            scripture1.Display();
            Console.Write("Press enter to continue. type quit to exit. type hint for a hint: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "quit":
                    running = false;
                    break;
                case "hint":
                    //additional method that displays a single letter hint of a random hidden word
                    scripture1.DisplayHint();
                    Console.ReadLine();
                    break;
                default:
                    running = !scripture1.HideN(3);
                    break;
            }
        }
    }
}