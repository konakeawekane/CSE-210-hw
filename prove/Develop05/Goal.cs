public abstract class Goal
{
    private string _goal;
    private string _description;
    private int _pointValue;
    private bool _isCompleted;

    public Goal(string goal, string description, int points)
    {
        _goal = goal;
        _description = description;
        _pointValue = points;
        _isCompleted = false;
    }

    public virtual string SerializeGoal()
    {
        return $"Goal~{_goal}~{_description}~{_pointValue}~{_isCompleted}";
    }

    public virtual string GetGoal()
    {
        return _goal;
    }
    public virtual string GetDescription()
    {
        return _description;
    }
    public virtual int GetPoints()
    {
        return _pointValue;
    }

    public virtual string GetFormatedGoal()
    {   
        string check = GetIsComplete() ? " " : "X";
        return $"[{check}] {_goal} ({_description})";
    }

    public virtual bool GetIsComplete()
    {
        return _isCompleted;
    }

    public abstract void RecordEvent();

    public void SetIsComplete(bool complete)
    {
        _isCompleted = complete;
    }
}