using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5DateModifier
{
    class DateModifier
    {
        public double GetDifferenceInDaysBetweenTwoDates(string firstDate, string secoundDate)
        {
            DateTime startDate = DateTime.Parse(firstDate);
            DateTime endDate = DateTime.Parse(secoundDate);

            double result = Math.Abs((startDate - endDate).TotalDays);

            return result;
        }
    }
}
