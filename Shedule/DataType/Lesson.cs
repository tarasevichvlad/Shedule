using System;
using System.Collections.Generic;
using System.Text;

namespace Shedule.DataType
{
    class Lesson
    {
        int Number { get; set; }
        Subject Subject { get; set; }
        Teacher Teacher { get; set; }
        Cabinet Cabinet { get; set; } 
    }
}
