using System;
using System.Collections.Generic;
using System.Text;

namespace Shedule.DataType
{
    class Day
    {
        string Name { get; set; }
        int CountLesson { get; set; }
        int IndexDifficulty { get; set; }
        List<Lesson> Lesson { get; set; }
        Class Class { get; set; }
    }
}
