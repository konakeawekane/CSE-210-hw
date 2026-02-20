public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string textbook, string problems, string studentName, string topic) : 
        base(studentName, topic) 
    {
        _textBookSection = textbook;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}