public class BreathingActivity : Activity
{
    private int _breathDuration;
    public BreathingActivity(int breathDuration) : 
        base("Breathing Activity","Take a few deep breaths in order to relax")
    {
        _breathDuration = breathDuration;
    }

    public void RunActivity()
    {
        DisplayStartMessage();

        int duration = int.Parse(Console.ReadLine());
        for(int i = 0; i < duration / _breathDuration; i++)
        {
            Breath(_breathDuration);
        }

        DisplayEndMessage();
    }

    public void Breath(int seconds)
    {
        Console.WriteLine($"slowly breath out for {seconds}");
        Thread.Sleep(1000);
        Console.WriteLine($"slowly breath in for {seconds}");
        Thread.Sleep(1000);
        Console.WriteLine();
    }


}