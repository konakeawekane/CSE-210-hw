using System;

class Program
{
    static void Main(string[] args)
    {
        Reception reception = new Reception(
            "Bob's Pizza Reception",
            "Bob hosts a pizza reception because he feels like it",
            "5/8/26",
            "12:00PM",
            new Address(
                "412 E Rd",
                "Rexburg",
                "ID",
                "USA"
            ),
            "bob@gmail.com"
        );

        Lecture lecture = new Lecture(
            "Mikes Ted Talk",
            "Mike talks about OOP",
            "4/20/26",
            "2:00PM",
            new Address(
                "341 W St",
                "Provo",
                "UT",
                "USA"
            ),
            "Mike",
            315
        );

        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Morning Pancakes at the Park",
            "Come to the park and eat Pancakes",
            "6/28/26",
            "10:00AM",
            new Address(
                "200 Park St",
                "Henderson",
                "NV",
                "USA"
            ),
            "Lightly Overcast UVIndex-3.1 Precipitation-3%"
        );

        Console.WriteLine("Standard Details ------");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details ------");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description ------");
        Console.WriteLine(reception.GetShortDescription());
        
        Console.WriteLine();
        Console.WriteLine("Standard Details ------");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details ------");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description ------");
        Console.WriteLine(lecture.GetShortDescription());
        
        Console.WriteLine();
        Console.WriteLine("Standard Details ------");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details ------");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description ------");
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}