using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{ 
    public abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected int _points;

        public Goal(string name, string description, int points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        public string GetName() 
        {
            return _shortName;
        }

        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetDetailString();
        public abstract string GetStringRepresentation();
        public virtual int GetPoints() 
        {
            return _points;
        }
    }
}