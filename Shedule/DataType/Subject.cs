using System;
using System.Collections.Generic;

namespace SheduleData
{
    public class Subject
    {
        string Name { get; set; }
        public int Complexity { get; private set; }

        List<Subject> Adjacency = new List<Subject>();

        public void AddAdjacency(Subject subject) => Adjacency.Add(subject);
        public void RemoveAdjacency(Subject subject) => Adjacency.Remove(subject);
    }

}
