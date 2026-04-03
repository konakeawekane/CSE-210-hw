using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new RunningActivity(
            "07 Nov 2026",
            15,
            2.51f
        ));

        activities.Add(new CyclingActivity(
            "02 Nov 2026",
            30,
            25.7f
        ));

        activities.Add(new SwimmingActivity(
            "15 Oct 2022",
            23,
            10
        ));

        foreach(Activity activity in activities)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
        }
    }
}