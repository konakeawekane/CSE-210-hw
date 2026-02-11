public class Word
{
    private string _letters;
    private bool _hid;

    public Word(string letters)
    {
        _letters = letters;
        _hid = false;
    }

    public void Hide()
    {
        _hid = true;
    }

    public void UnHide()
    {
        _hid = false;
    }

    public void Toggle()
    {
        _hid = !_hid;
    }

    public bool GetHid()
    {
        return _hid;
    }

    public string GetString()
    {
        if (_hid)
        {
            string blank = "";
            for (int i = 0; i<_letters.Length; i++)
            {
                blank = blank + "_";
            }
            return blank;
        } else
        {
            return _letters;
        }
    }

    public char GetHint()
    {
        return _letters[0];
    }
}