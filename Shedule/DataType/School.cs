using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SheduleData.DataType
{
    class School
    {
        List<Cabinet> cabinets = new List<Cabinet>();
        List<Class> classes = new List<Class>();
        List<Teacher> teachers = new List<Teacher>();
        List<Subject> subjects = new List<Subject>();

        public void AddClass(Class _class) => classes.Add(_class);
        public void RemoveClass(Class _class) => classes.Remove(_class);
        public void AddTeacher(Teacher teacher) => teachers.Add(teacher);
        public void RemoveTeacher(Teacher teacher) => teachers.Remove(teacher);
        public void AddCabinet(Cabinet cabinet) => cabinets.Add(cabinet);
        public void RemoveCabinet(Cabinet cabinet) => cabinets.Remove(cabinet);
        public void AddSubject(Subject subject) => subjects.Add(subject);
        public void RemoveSubject(Subject subject) => subjects.Remove(subject);
    }
}
