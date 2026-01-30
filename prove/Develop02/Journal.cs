
using System.Linq.Expressions;
using System.IO;

public class Journal
{
    public List<Entry> _entries;
    PromptGenerator _prompter;

    public Journal()
    {
        _entries = new List<Entry>();
        _prompter = new PromptGenerator();
    }
    
    // Writes all menu options to the terminal
    public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Display");
        Console.WriteLine("2. Write");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }

    // Displays all journal entries to the terminal
    public void Display()
    {
        foreach(Entry entry in _entries)
        {
            Console.WriteLine(entry.GetEntry());
            Console.WriteLine();
        }
    }

    // Prompts the user for a new entry into the journal
    public void New()
    {
        DateTime time = DateTime.Now;
        string date = time.ToShortDateString();
        string prompt = _prompter.NextPrompt();

        Console.WriteLine($"{prompt}");
        Console.Write(">");
        string entry = Console.ReadLine();
        _entries.Add(new Entry(date, prompt, entry));
        Console.WriteLine();
    }

    // Load the journal entries from a txt file
    public void Load(string fileName)
    {
        try
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            _entries.Clear();
            foreach(string line in lines)
            {
                string[] segments = line.Split("---");
                _entries.Add(new Entry(segments[0], segments[1], segments[2]));
            }
        } catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine($"No {fileName} file found!");
            Console.WriteLine();
        }
        
    }

    // Saves the journal entries to a txt file
    public void Save(string fileName)
    {
        using (StreamWriter file = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                file.WriteLine($"{entry._date}---{entry._prompt}---{entry._entry}---");
            }
        }
    }
}