public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<int> unusedPrompts = new List<int>();
    private int entries;

    public ListingActivity() : 
        base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>();
        _prompts.AddRange(
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        );
        unusedPrompts.AddRange(0,1,2,3,4);
    }

    public void RunActivity()
    {
        DisplayStartMessage();

        Console.WriteLine("Write as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetNextPrompt()} ---");
        Console.Write("Your may begin in: ");
        CountDownFor(5);
        Console.WriteLine();

        entries = 0;
        DateTime listingEndTime = DateTime.Now.AddSeconds(getActivityTime());
        Console.CursorVisible = true;
        while (DateTime.Now < listingEndTime)
        {
            Console.Write("> ");
            if (Console.ReadLine().Length > 0)
            {
                entries++;
            }
        }
        Console.CursorVisible = false;
        Console.WriteLine($"You listed {entries} items!");

        DisplayEndMessage();
    }

    public string GetNextPrompt()
    {
        Random random = new Random();
        int index;
        if(unusedPrompts.Count == 0)
        {
            for(int i = 0; i < _prompts.Count; i++)
            {
                unusedPrompts.Add(i);
            }
        }
        index = unusedPrompts[random.Next(0,unusedPrompts.Count)];
        unusedPrompts.Remove(index);
        return _prompts[index];
    }
}