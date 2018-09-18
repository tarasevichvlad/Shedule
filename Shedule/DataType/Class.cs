using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleData.DataType
{
    class Class
    {
        string Name { get; set; }
        List<Subject> subjects = new List<Subject>();
        Teacher Teacher { get; set; }

        public void AddSubject(Subject subject) => subjects.Add(subject);
        public void RemoveSubject(Subject subject) => subjects.Add(subject);
    }
}
