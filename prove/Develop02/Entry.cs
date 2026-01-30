public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;

    public Entry()
    {
        _date = "";
        _prompt = "";
        _entry = "";
    }

    public Entry(string date, string prompt, string entry)
    {
        _date = date;
        _prompt = prompt;
        _entry = entry;
    }

    // Gets the entery data as a printable string
    public string GetEntry()
    {
        return $"Date: {_date} — Prompt: {_prompt}\n{_entry}";
    }
}