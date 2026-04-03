public class OutdoorGathering : Event
{
    private string _weatherForcast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : 
        base(title, description, date, time, address)
    {
        _weatherForcast = weather;
    }

    public string GetFullDetails()
    {
        return $"Event - Outdoor Gathering\n{GetStandardDetails()}\nWeather - {_weatherForcast}";
    }

    public string GetShortDescription()
    {
        return $"Event - OutdoorGathering\nTitle - {GetTitle()}\nDate - {GetDate()}";
    }
}