public class SwimmingActivity : Activity
{
    private int _laps;
    public SwimmingActivity(string date, int length, int laps) : 
        base(date, length)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps * 50 / 1000.0f * 0.62f;
    }
    public override float GetSpeed()
    {
        return GetDistance() / GetDuration() * 60;
    }
    public override float GetPace()
    {
        return GetDuration() / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetDuration()} min)- Distance: {GetDistance():F1} miles,\n Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
