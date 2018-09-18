using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleData.DataType
{
    class Week
    {
        public Week(int numberAcademicWeek)
        {
            NumberAcademicWeek = numberAcademicWeek;
        }
        List<Day> Days { get; } = new List<Day>();
        int NumberAcademicWeek { get; }
        public void AddDay(Day day) => Days.Add(day);
        public void RemoveDay(Day day) => Days.Remove(day);
    }
}
