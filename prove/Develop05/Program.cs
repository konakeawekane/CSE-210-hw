using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;
        string input;
        // Console.Clear();

        while (running)
        {
            Console.WriteLine($"You have {manager.GetPoints()} points.");
            Console.WriteLine();
            DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();
            switch (input)
            {
                case("1"):
                    Console.WriteLine();
                    DisplayGoalCreationMenu();
                    Console.Write("Which type of goal would you like to create? ");
                    input = Console.ReadLine();
                    string name;
                    string description;
                    int points;
                    switch (input)
                    {
                        case("1"):
                            Console.Write("What is the name of your goal? ");
                            name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();
                            Console.Write("What is the amount of points assosiated with this goal? ");
                            points = int.Parse(Console.ReadLine());
                            manager.AddGoal(new SimpleGoal(name, description, points));
                            break;
                        case("2"):
                            Console.Write("What is the name of your goal? ");
                            name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();
                            Console.Write("What is the amount of points assosiated with this goal? ");
                            points = int.Parse(Console.ReadLine());
                            manager.AddGoal(new EternalGoal(name, description, points));
                            break;
                        case("3"):
                            Console.Write("What is the name of your goal? ");
                            name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();
                            Console.Write("What is the amount of points assosiated with this goal? ");
                            points = int.Parse(Console.ReadLine());
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            int count = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            int bonus = int.Parse(Console.ReadLine());
                            manager.AddGoal(new CheckListGoal(name, description, points, count, bonus));
                            break;
                        default:
                            Console.WriteLine("Invalid input try again.");
                            Thread.Sleep(1000);
                            break;
                    }
                    break;
                case("2"):
                    Console.WriteLine();
                    Console.WriteLine("The goals are: ");
                    manager.ListGoals();
                    Console.WriteLine();
                    break;
                case("3"):
                    Console.Write("What is the filename for the goal file? ");
                    input = Console.ReadLine();
                    manager.Save(input);
                    break;
                case("4"):
                    Console.Write("What is the filename for the goal file? ");
                    input = Console.ReadLine();
                    try
                    {
                        manager.Load(input);
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine($"Error: File not found by name of - {input}");
                        Thread.Sleep(1000);
                    }
                    break;
                case("5"):
                    manager.DisplayGoals();
                    Console.Write("Which goal did you accomplish? ");
                    input = Console.ReadLine();
                    if(int.Parse(input) > 0 && int.Parse(input) <= manager.GetGoals().Count)
                    {
                        manager.RecordEvent(int.Parse(input) - 1);
                    }
                    break;
                case("6"):
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid input try again.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
    }

    static void DisplayGoalCreationMenu()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Check List Goal");
    }
}