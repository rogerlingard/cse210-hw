using System;

class Program
{
    static void Main(string[] args)
    {
       Cycling cycling = new("11 Dec 2024", 60, 15.0);

       Running running = new("03 Nov 2024", 30, 3.0);

       Swimming swimming = new("04 Jun 2024", 45, 40);

        List<Activity> activities = new();

        activities.Add(cycling);
        activities.Add(running);
        activities.Add(swimming);

        foreach(Activity activity in activities){
            string activities_show = activity.getSummary();

            Console.WriteLine(activities_show);
        }

    }
}