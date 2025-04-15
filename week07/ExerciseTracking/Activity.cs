using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        protected DateTime _date;
        protected int _duration;

        public Activity(DateTime date, int duration)
        {
            _date = date;
            _duration = duration;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_duration} min) \n\t- Distance {GetDistance():F1} miles, \n\t- Speed {GetSpeed():F1} mph, \n\t- Pace: {GetPace():F2} min per mile \n";
        }
    }
}