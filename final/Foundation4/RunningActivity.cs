public class RunningActivity : Activity
{
    private float _distance;

    public RunningActivity(string date, int length, float distance) : 
        base(date, length)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetSpeed()
    {
        return _distance / GetDuration() * 60.0f;
    }
    public override float GetPace()
    {
        return GetDuration() / _distance;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetDuration()} min)- Distance: {GetDistance():F1} miles,\n Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}