using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamHelpers
{
    public static class BoolExtensions
    {
        /// <summary>
        /// Convert bool to English text
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToYesNoString(this bool value) => value ? "Yes" : "No";
        /// <summary>
        /// Convert string to bool
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ToBoolean(this string value)
        {
            string[] trueStrings = { "1", "y", "yes", "true" };
            string[] falseStrings = { "0", "n", "no", "false" };


            if (trueStrings.Contains(value, StringComparer.OrdinalIgnoreCase))
            {
                return true;
            }

            if (falseStrings.Contains(value, StringComparer.OrdinalIgnoreCase))
            {
                return false;
            }

            throw new InvalidCastException($"only the following are supported for converting strings to boolean: {string.Join(",", trueStrings)} and {string.Join(",", falseStrings)}");
        }
    }
}
