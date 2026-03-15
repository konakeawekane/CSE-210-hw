public class EternalGoal : Goal
{
    public EternalGoal(string goal, string description, int points) : base(goal, description, points){}

    public override void RecordEvent(){}

    public override bool GetIsComplete()
    {
        return false;
    }
}