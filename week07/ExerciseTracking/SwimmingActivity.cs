using System;

namespace ExerciseTracking
{
    public class SwimmingActivity : Activity
    {
        private int _laps;

        public SwimmingActivity(DateTime date, int duration, int laps) : base(date, duration)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return _laps * 50 / 1000 * 0.62;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / (_duration / 60.0)) * 60;
        }

        public override double GetPace()
        {
            return _duration / GetDistance();
        }
    }
}