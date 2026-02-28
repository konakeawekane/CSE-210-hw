public class BreathingActivity : Activity
{
    private int _breathDuration;
    public BreathingActivity(int breathDuration) : 
        base("Breathing Activity","This Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        _breathDuration = breathDuration;
    }

    public void RunActivity()
    {
        DisplayStartMessage();

        int duration = getActivityTime();
        if(duration < _breathDuration * 2) {duration = _breathDuration * 2;}
        for(int i = 0; i < duration / (_breathDuration * 2); i++)
        {
            Breath(_breathDuration);
        }

        DisplayEndMessage();
    }

    public void Breath(int seconds)
    {
        Console.Write("Breath in...");
        CountDownFor(seconds);
        Console.WriteLine();
        Console.Write("Now Breath out...");
        CountDownFor(seconds);
        Console.WriteLine("\n");
    }


}