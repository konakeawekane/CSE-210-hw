using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public int GetPoints()
    {
        return _totalPoints;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {   
        int i = 0;
        foreach(Goal goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}. {goal.GetFormatedGoal()}");
        }
    }

    public void DisplayGoals()
    {
        int i = 0;
        foreach(Goal goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}. {goal.GetGoal()}");
        }
    }

    public void RecordEvent(int goal)
    {
        _goals[goal].RecordEvent();
    }

    public void AddPoints(int goal)
    {
        _goals[goal].GetPoints();
    }

    public void Load(string path)
    {
        List<string> lines =  File.ReadAllLines(path).ToList<string>();

        _totalPoints = int.Parse(lines[0]);
        lines.RemoveAt(0);
        _goals.Clear();

        foreach (string line in lines)
        {
            string[] values = line.Split("~");
            switch (values[0])
            {
                case("SimpleGoal"):
                    _goals.Add(new SimpleGoal(values[1], values[2], int.Parse(values[3])));
                    break;
                case("EnternalGoal"):
                    _goals.Add(new EternalGoal(values[1], values[2], int.Parse(values[3])));
                    break;
                case("CheckListGoal"):
                    _goals.Add(new CheckListGoal(values[1], values[2], int.Parse(values[3]), int.Parse(values[4]), int.Parse(values[5])));
                    break;
                default:
                    throw new Exception($"Error: Unknown Goal Type - {values[0]}");
            }
        }
    }

    public void Save(string path)
    {
        using (StreamWriter output = new StreamWriter(path))
        {
            output.WriteLine(_totalPoints);
            foreach(Goal goal in _goals)
            {
                output.WriteLine(goal.SerializeGoal());
            }
        }
    }
}