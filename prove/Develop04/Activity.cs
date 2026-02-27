using System.Diagnostics;

public class Activity
{
    private string _name;
    private string _description;
    private int _time;

    public Activity(string type, string description)
    {
        _name = type;
        _description = description;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long in seconds would you like your session? ");
        Console.CursorVisible = true;
        _time = int.Parse(Console.ReadLine());
        Console.CursorVisible = false;
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ThrobberFor(4);
        Console.Clear();
    }

    public int getActivityTime()
    {
        return _time;
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("temporary end message");
    }

    public void CountDownFor(int seconds)
    {
        for(int i = seconds; i > 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ThrobberFor(int seconds)
    {
        for(int i = 0; i < seconds * 10; i++)
        {
            Console.Write(new string[] {"-","\\","|","/"}[i % 4]);
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
    }

    public void ProgressBarFor(int seconds, int length)  // Added additional delay animation (loading bar)
    {
        if (length > 0){
            for(int i = 0; i < length; i++)
            {
                Console.Write(new string('█',i));
                Console.Write(new string('░',length - i));
                Thread.Sleep(1000 * seconds / length);  // delay set to match each printed character in bar
                Console.Write(new string('\b',length));
                Console.Write(new string(' ',length));
                Console.Write(new string('\b',length));
            }
        } else
        {
            Thread.Sleep(seconds);
        }
    }
}
