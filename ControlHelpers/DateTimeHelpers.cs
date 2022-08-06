using System.Collections.Generic;
using System.Linq;
using static System.Globalization.DateTimeFormatInfo;


namespace TeamHelpers
{
    public static class DateTimeHelpers
    {
        /// <summary>
        /// Returns a string list of month names for the current culture
        /// </summary>
        /// <returns>
        /// List of month names for current culture
        /// </returns>
        public static List<string> MonthNames()
            => CurrentInfo!.MonthNames[..^1].ToList();

        public static List<string> MonthsWithSelect()
        {
            var months = MonthNames();

            months.Insert(0,"Select");

            return months;

        }
	}
}
