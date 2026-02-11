public class Referance {
    
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Referance(string book, int chapter, int verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = 0;
    }

    public Referance(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string GetReferance()
    {
        string verses = _verseStart.ToString();
        if (!(_verseEnd == 0)) {verses = verses + "—" + _verseEnd.ToString();}
        
        return $"{_book} {_chapter}:{verses}";
    }

}