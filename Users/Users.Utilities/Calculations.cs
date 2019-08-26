using System;
using System.Globalization;

namespace Utilities
{
    public class Calculations
    {
        public static string CalculateTimeToStart(DateTime startDate, DateTime assignedDate)
        {
            var days = (startDate - assignedDate).TotalDays;

            return days >= 0 ? days.ToString(CultureInfo.InvariantCulture) : "Started";
        }
    }
}
