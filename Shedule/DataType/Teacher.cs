using System;
using System.Collections.Generic;
using System.Text;

namespace Shedule.DataType
{
    class Teacher
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Patronymic { get; set; }
        Subject Subject { get; set; }
        List<Class> Classes { get; set; }
    }
}
