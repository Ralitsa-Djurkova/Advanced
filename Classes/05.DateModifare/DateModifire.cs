using System;
using System.Collections.Generic;
using System.Text;

namespace _05.DateModifare
{
    public static class DateModifier
    {
        public static int GetDiffBetweenDatesInDays(string dateOneString, string dateTowStr)
        {
            DateTime dateOne = DateTime.Parse(dateOneString);
            DateTime dateTwo = DateTime.Parse(dateTowStr);

            TimeSpan diff = dateOne - dateTwo;

            return Math.Abs(diff.Days);

            
        }
    }
}
