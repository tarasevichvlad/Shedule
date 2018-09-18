using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleData.DataType
{
    class Day
    {
        public Day(string nameDay, Class _class)
        {
            Name = nameDay;
            Class = _class;
        }

        private string Name { get; }

         public int IndexDifficulty
        {
            get => IndexDifficulty/Lessons.Count;
            private set => Lessons.ForEach(x => IndexDifficulty += x.Subject.Complexity);
        } 

        Class Class { get;}

        List<Lesson> Lessons = new List<Lesson>();

        public void AddLesson(Lesson lesson) => Lessons.Add(lesson);

        public void RemoveLesson(Lesson lesson) => Lessons.Remove(lesson);
    }
}
