public class SimpleGoal : Goal
{
    public SimpleGoal(string goal, string description, int points) : base(goal, description, points){}

    public override string SerializeGoal()
    {
        return $"{GetGoal()}~{GetDescription()}~{GetPoints()}~{GetIsComplete()}";
    }

    public override void RecordEvent()
    {
        SetIsComplete(true);
    }

}