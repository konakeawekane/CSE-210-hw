public class Video
{
    private string _name;
    private string _description;
    private float _duration;

    private List<Comment> _comments;
    public Video(string name, string description, float duration) 
    {
        _name = name;
        _description = description;
        _duration = duration;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void Display()
    {
        Console.WriteLine($"Video - name: {_name}, description: {_description}, duration: {_duration}");

        foreach(Comment comment in _comments)
        {
            comment.Display();
        }
        
        Console.WriteLine();
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }
}