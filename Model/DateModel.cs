using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabanut.Model
{
    internal record DateModel (
        string DayInWeek,
        string DayInMonth,
        string Month,
        string Year,
        string Result
        );
}
