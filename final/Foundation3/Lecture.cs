public class Lecture : Event
{
    private string _speaker;
    private int _maxCapacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : 
        base(title, description, date, time, address)
    {
        _speaker = speaker;
        _maxCapacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"Event - Lecture\nSpeaker - {_speaker}\nCapacity - {_maxCapacity}\n{GetStandardDetails()}";
    }

    public string GetShortDescription()
    {
        return $"Event - Lecture\nTitle - {GetTitle()}\nDate - {GetDate()}";
    }
}