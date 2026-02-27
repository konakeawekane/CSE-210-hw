using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity(6);
        ListingActivity listingActivity = new ListingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        bool running = true;
        string input;
        while (running)
        {
            DisplayMenu();
            Console.CursorVisible = true;
            input = Console.ReadLine();
            Console.CursorVisible = false;
            switch (input)
            {
                case "1":
                    breathingActivity.RunActivity();
                    break;
                case "2":
                    listingActivity.RunActivity();
                    break;
                case "3":
                    reflectionActivity.RunActivity();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1) Start breathing activity");
        Console.WriteLine("   2) Start listing activity");
        Console.WriteLine("   3) Start reflection activity");
        Console.WriteLine("   4) Quit");
        Console.Write("Select a choice from the menu: ");
    }   
}