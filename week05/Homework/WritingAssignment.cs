using System;

namespace Homework 
{
    public class WritingAssignment : Assignment 
    {
        private string _title;

        public WritingAssignment(string studentName, string topic, string title) 
            : base(studentName, topic)
        {
            _title = title;
        }

        public string GetWritingInfo()
        {
            return $"{base._studentName} - {base._topic} \n{_title}";
        }
    }
}