using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points) { }

        public override void RecordEvent() 
        { 
            /* 
               No action needed for eternal goals because 
               Eternal goals are never complete
            */ 
        }

        public override bool IsComplete() 
        {
            return false;
        }

        public override string GetDetailString()
        {
            return $"[ ] {_shortName}: {_description} (Points: {_points}) - Eternal Goal";
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal,{_shortName},{_description},{_points}";
        }
    }
}