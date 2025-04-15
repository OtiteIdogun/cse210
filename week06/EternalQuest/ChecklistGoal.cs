using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }

        public void SetAmountCompleted(int amount) 
        {
            return _amountCompleted = amount;
        } 

        public int GetBonus() 
        {
            return _bonus;
        }

        public override void RecordEvent()
        {
            if (_amountCompleted < _target)
            {
                _amountCompleted++;
            }
        }

        public override bool IsComplete() 
        {
            return _amountCompleted >= _target;
        } 

        public override string GetDetailString()
        {
            return IsComplete() ? $"[X] {_shortName}: {_description} (Completed: {_amountCompleted}/{_target} - Bonus: {_bonus})" :
                                 $"[ ] {_shortName}: {_description} (Completed: {_amountCompleted}/{_target})";
        }

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal,{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
        }
    }
}