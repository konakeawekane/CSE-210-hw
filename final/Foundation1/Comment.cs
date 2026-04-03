public class Comment
{
    private string _author;
    private string _message;

    public Comment(string author, string message)
    {
        _author = author;
        _message = message;
    }

    public void Display()
    {
        Console.WriteLine($"Comment by {_author}: {_message}");
    }
}