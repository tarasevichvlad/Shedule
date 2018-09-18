using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleData.DataType
{
    class Lesson
    {
        int Number { get; set; }
        public Subject Subject { get; private set; }
        Teacher Teacher { get; set; }
        Cabinet Cabinet { get; set; } 

    }
}
