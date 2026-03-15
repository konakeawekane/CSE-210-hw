public class EternalGoal : Goal
{
    public EternalGoal(string goal, string description, int points) : base(goal, description, points){}

    public override void RecordEvent(){}

    public override string SerializeGoal()
    {
        return $"{GetGoal()}~{GetDescription()}~{GetPoints()}";
    }

    public override bool GetIsComplete()
    {
        return false;
    }
}