using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    public class Program
    {
        public static void Main()
        {
            List<Activity> _activities = new List<Activity>
            {
                new RunningActivity(new DateTime(2022, 11, 3), 30, 3.0),
                new CyclingActivity(new DateTime(2022, 11, 3), 30, 10.0),
                new SwimmingActivity(new DateTime(2022, 11, 3), 30, 30)
            };

            foreach (var activity in _activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}