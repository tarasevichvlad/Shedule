using System;
using System.Collections.Generic;
using System.Text;

namespace Shedule.DataType
{
    class Replacement
    {
        int Id { get; set; }
        DateTime PreviolusDateTime { get; set; }
        DateTime NewDateTime { get; set; }
        Subject PreviolusSubject { get; set; }
        Subject NewSubject { get; set; }
    }
}
