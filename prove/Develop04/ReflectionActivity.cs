public class ReflectionActivity : Activity
{
    private List<string> _initialPrompts;
    private List<string> _secondaryPrompts;

    public ReflectionActivity() : 
        base("Reflection Activity", "Take some time and ponder these prompts")
    {
        _initialPrompts = new List<string>();
        _initialPrompts.AddRange(
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        );
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
    }

    public void RunActivity()
    {
        Random random = new Random();

        DisplayStartMessage();

        Console.WriteLine(_initialPrompts[random.Next(0,_initialPrompts.Count)]);
        Thread.Sleep(1000);
        Console.ReadLine();
        Console.WriteLine(_secondaryPrompts[random.Next(0,_initialPrompts.Count)]);
        Thread.Sleep(1000);
        Console.ReadLine();

        DisplayEndMessage();
    }

}