using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Workhous.Utils
{
    public class DateTimeUtil
    {
        public static DateTime firstDayOfTheMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        public static DateTime lastDayOfTheMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }

        public static bool isDateWithinRange(DateTime dateToCheck, DateTime lowerBound, DateTime upperBound)
        {
            return DateTime.Compare(lowerBound, dateToCheck) <= 0 && DateTime.Compare(upperBound, dateToCheck) >= 0;
        }
    }
}