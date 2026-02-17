using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        // Create a list of Activity objects
        List<Activity> activities = new List<Activity>();

        // Add one of each type
        activities.Add(new RunningActivity("03 Nov 2022", 30, 3.0));
        activities.Add(new RunningActivity("06 Nov 2022", 45, 4.5));
        activities.Add(new RunningActivity("10 Nov 2022", 25, 2.2));

        activities.Add(new CyclingActivity("04 Nov 2022", 45, 15.0));
        activities.Add(new CyclingActivity("08 Nov 2022", 60, 18.5));
        activities.Add(new CyclingActivity("12 Nov 2022", 30, 12.0));

        activities.Add(new SwimmingActivity("05 Nov 2022", 40, 20));
        activities.Add(new SwimmingActivity("09 Nov 2022", 35, 30));
        activities.Add(new SwimmingActivity("15 Nov 2022", 50, 40));


        // Loop through all activities and display summary
        foreach (Activity activity in activities)
        {
            // Runtime polymorphism: the overridden method is invoked 
            // based on the object's actual type
            Console.WriteLine($"\n{activity.GetSummary()}");
        }
        Console.WriteLine("");

    }

}