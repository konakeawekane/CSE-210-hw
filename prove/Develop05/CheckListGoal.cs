public class CheckListGoal : Goal
{
    public int _count;
    public int _countCompleted;
    public int _perEventPoints;
    public CheckListGoal(string goal, string description, int points, int count, int bonus) : base(goal, description, bonus)
    {
        _count = count;
        _countCompleted = 0;
        _perEventPoints = points;
    }

    public override void RecordEvent()
    {
        if(_countCompleted < _count)
        {
            _count++;
        }
        else
        {
            SetIsComplete(true);
        }
    }

    public override int GetPoints()
    {
        if(_countCompleted < _count)
        {
            return _perEventPoints;
        }
        else
        {
            return base.GetPoints();
        }
    }

    public override string GetFormatedGoal()
    {
        string check = GetIsComplete() ? " " : "X";
        return $"[{check}] {GetGoal()} ({GetDescription()}) -- Currently Completed: {_countCompleted}/{_count}";
    }
}