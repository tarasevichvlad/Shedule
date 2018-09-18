using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleData.DataType
{
    class Teacher
    {
        public Teacher(string name, string surname, string patronymic, Subject subject)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Subject = subject;
        }

        string Name { get; }
        string Surname { get;  }
        string Patronymic { get; }
        Subject Subject { get; }

        List<Class> classes { get; } = new List<Class>();

        public void AddClass(Class _class) => classes.Add(_class);

        public void RemoveClass(Class _class) => classes.Remove(_class);
    }
}
