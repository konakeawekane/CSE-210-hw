public class SimpleGoal : Goal
{
    public SimpleGoal(string goal, string description, int points) : base(goal, description, points){}

    public override void RecordEvent()
    {
        SetIsComplete(true);
    }

}