using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public static class DateModifier
    {
        public static double GetDiffBetweenTwoDates(string firstDate, string secondDate)
        {
            DateTime first = DateTime.Parse(firstDate);
            DateTime second = DateTime.Parse(secondDate);

            double diff = (first - second).TotalDays;
            double result = Math.Abs(diff);

            return result;
        }
    }
}
