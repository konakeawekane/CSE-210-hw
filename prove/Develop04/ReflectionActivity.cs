public class ReflectionActivity : Activity
{
    private List<string> _initialPrompts;
    private List<string> _secondaryPrompts;

    private List<int> _validInitialPrompts;
    private List<int> _validSecondaryPrompts;

    public ReflectionActivity() : 
        base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _initialPrompts = new List<string>();
        _initialPrompts.AddRange(
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        );
        _validInitialPrompts = new List<int>();
        _validInitialPrompts.AddRange(0,1,2,3);
        _secondaryPrompts = new List<string>();
        _secondaryPrompts.AddRange(
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        );
        _validSecondaryPrompts = new List<int>();
        _validSecondaryPrompts.AddRange(0,1,2,3,4,5,6,7,8);
    }

    public void RunActivity()
    {
        DisplayStartMessage();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"--- {GetInitialPrompt()} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        CountDownFor(4);
        Console.Clear();
        int duration = getActivityTime();
        if (duration < 8) {duration = 8;}
        for(int i = 0; i < duration / 8; i++)
        {
           Console.Write($"> {GetSecondaryPrompt()} ");
           ThrobberFor(7);
           Console.WriteLine();
        }

        DisplayEndMessage();
    }

    private string GetInitialPrompt()
    {
        Random random = new Random();
        int index;
        if(_validInitialPrompts.Count == 0)
        {
            for(int i = 0; i < _initialPrompts.Count; i++)
            {
                _validInitialPrompts.Add(i);
            }
        }
        index = _validInitialPrompts[random.Next(0,_validInitialPrompts.Count)];
        _validInitialPrompts.Remove(index);
        return _initialPrompts[index];
    }

    private string GetSecondaryPrompt()
    {
        Random random = new Random();
        int index;
        if(_validSecondaryPrompts.Count == 0)
        {
            for(int i = 0; i < _initialPrompts.Count; i++)
            {
                _validSecondaryPrompts.Add(i);
            }
        }
        index = _validSecondaryPrompts[random.Next(0,_validSecondaryPrompts.Count)];
        _validSecondaryPrompts.Remove(index);
        return _secondaryPrompts[index];
    }
}