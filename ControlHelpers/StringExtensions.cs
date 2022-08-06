using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TeamHelpers
{
    public static class StringExtensions
    {
        /// <summary>
        /// Convert string to an enum member
        /// </summary>
        /// <typeparam name="T">Enum type</typeparam>
        /// <param name="value">Value to convert</param>
        /// <param name="defaultValue">Default value if an issue arises in the form of an empty string</param>
        /// <returns></returns>
        public static T ToEnum<T>(string value, T defaultValue) where T : struct
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return defaultValue;
            }

            return Enum.TryParse<T>(value, out var result) ? result : defaultValue;
        }

        /// <summary>
        /// Replace multiple spaces with a single space.
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static string RemoveMultipleSpaces(this string sentence) => Regex.Replace(sentence, @"\s+", " ");
        /// <summary>
        /// Split string on upper cased characters
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static string SplitCamelCase(this string sender) 
            => Regex.Replace(Regex.Replace(sender, "(\\P{Ll})(\\P{Ll}\\p{Ll})", "$1 $2"), "(\\p{Ll})(\\P{Ll})", "$1 $2");
        /// <summary>
        /// Get int from string where there may be alpha characters
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>null if no int else an int</returns>
        public static int? AsInt(this string sender) => int.TryParse(Regex.Match(sender, @"\d+").Value, out var value) ? (int?) value : null;
        /// <summary>
        /// Get decimal from string  where there may be alpha characters
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>null if no decimal else an decimal</returns>        
        public static decimal? AsDecimal(this string sender) => decimal.TryParse(Regex.Match(sender, @"\d+").Value, out var value) ? (int?) value : null;
        /// <summary>
        /// Get double from string  where there may be alpha characters
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>null if no double else an double</returns>                
        public static double? AsDouble(this string sender) => double.TryParse(Regex.Match(sender, @"\d+").Value, out var value) ? (int?) value : null;
        /// <summary>
        /// Join string array with " and " as the last delimiter.
        /// </summary>
        /// <param name="sender">String array to convert to delimited string</param>
        /// <returns>Delimited string</returns>
        public static string JoinWithLastSeparator(this string[] sender) => string.Join(", ", sender.Take(sender.Length - 1)) + ((((sender.Length <= 1) ? "" : " and ")) + sender.LastOrDefault());
        /// <summary>
        /// Join string array with specified delimiter, " and " for the last delimiter
        /// </summary>
        /// <param name="sender">String array to convert to delimited string</param>
        /// <param name="pDelimiter">Delimiter to separate array items</param>
        /// <returns>Delimited string</returns>
        public static string JoinWithLastSeparator(this string[] sender, string pDelimiter) => string.Join(pDelimiter + " ", sender.Take(sender.Length - 1)) + ((((sender.Length <= 1) ? "" : " and ")) + sender.LastOrDefault());
        /// <summary>
        /// Join string array with specified delimiter and last delimiter
        /// </summary>
        /// <param name="sender">String array to convert to delimited string</param>
        /// <param name="pDelimiter">Delimiter to separate array items</param>
        /// <param name="pLastDelimiter">Token used for final delimiter</param>
        /// <returns>Delimited string</returns>
        public static string JoinWithLastSeparator(this string[] sender, string pDelimiter, string pLastDelimiter) => string.Join(pDelimiter + " ", sender.Take(sender.Length - 1)) + ((((sender.Length <= 1) ? "" : pLastDelimiter)) + sender.LastOrDefault());

        /// <summary>
        /// Truncates a string to the specified length.
        /// </summary>
        /// <param name="value">The string to be truncated.</param>
        /// <param name="length">The maximum length.</param>
        /// <param name="ellipsis"><c>true</c> to add ellipsis to the truncated text; otherwise, <c>false</c>.</param>
        /// <returns>Truncated string.</returns>
        /// <remarks>
        /// https://github.com/windows-toolkit/WindowsCommunityToolkit/blob/master/Microsoft.Toolkit/Extensions/StringExtensions.cs#L157
        /// </remarks>
        public static string Truncate(this string value, int length, bool ellipsis)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                value = value!.Trim();

                if (value.Length > length)
                {
                    if (ellipsis)
                    {
                        return value.Substring(0, length) + "...";
                    }

                    return value.Substring(0, length);
                }
            }

            return value ?? string.Empty;
        }
    }
}

