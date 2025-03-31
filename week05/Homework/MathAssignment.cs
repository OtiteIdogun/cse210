using System;

namespace Homework 
{
    public class MathAssignment : Assignment 
    {
        private string _textBookSelection;
        private string _problem;

        public MathAssignment(string studentName, string topic, string textBookSelection, string problem) : base(studentName, topic)
        {
            _textBookSelection = textBookSelection;
            _problem = problem;
        }

        public string GetHomeworkList()
        {
            return $"{base.GetSummary()} \n{_textBookSelection} {_problem}";
        }
    }
}