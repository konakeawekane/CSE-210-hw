using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string selection = "";

        Console.WriteLine("Welcome to the Journal Program!");

        // Main Journal program loop

        while (!(selection == "5"))
        {   
            journal.DisplayMenu();
            selection = Console.ReadLine();

            if(selection == "1")
            {
                journal.Display();

            } else if(selection == "2")
            {
                journal.New();

            } else if(selection == "3")
            {
                Console.Write("Enter file name to save: ");
                string name = Console.ReadLine();
                journal.Save(name);

            } else if(selection == "4")
            {
                Console.Write("Enter file name to load: ");
                string name = Console.ReadLine();
                journal.Load(name);

            } else if(selection == "5")
            {
                break;

            } else
            {
                Console.WriteLine("Unexpected input!");

            }
        }
    }
}