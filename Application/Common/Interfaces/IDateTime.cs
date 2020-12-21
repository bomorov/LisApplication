using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common.Interfaces
{
    public interface IDateTime
    {
        DateTime Now { get; }

        DateTime GetDeadLineDate(DateTime startDate, int daysCount, List<DateTime> holidays = null);
    }
}
