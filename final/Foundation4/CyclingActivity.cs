public class CyclingActivity : Activity
{
    private float _speed;

    public CyclingActivity(string date, int length, float speed) : 
        base(date, length)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return _speed * GetDuration() / 60.0f;
    }
    public override float GetSpeed()
    {
        return _speed;
    }
    public override float GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetDuration()} min)- Distance: {GetDistance():F1} miles,\n Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }

}