using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamHelpers
{
    /// <summary>
    /// Extension methods to get values from a data reader where value may be null or DBNull
    /// </summary>
    public static class DataReaderExtensions
    {
        /// <summary>
        /// Gets the record value cast as int or 0.
        /// </summary>
        /// <param name = "pReader">The data reader.</param>
        /// <param name = "pField">The name of the record field.</param>
        /// <returns>The record value</returns>
        public static int GetInt32Safe(this IDataReader pReader, string pField)
        {
            return pReader.GetInt32Safe(pField, 0);
        }
        /// <summary>
        /// Gets the record value cast as int or the specified default value.
        /// </summary>
        /// <param name = "pReader">The data reader.</param>
        /// <param name = "pField">The name of the record field.</param>
        /// <param name = "pDefaultValue">The default value.</param>
        /// <returns>The record value</returns>
        public static int GetInt32Safe(this IDataReader pReader, string pField, int pDefaultValue)
        {
            var value = pReader[pField];
            return ((value is int) ? Convert.ToInt32((int)(value)) : pDefaultValue);
        }
        /// <summary>
        /// Gets the record value casted as decimal or 0.
        /// </summary>
        /// <param name = "pReader">The data reader.</param>
        /// <param name = "pField">The name of the record field.</param>
        /// <returns>The record value</returns>
        public static double GetDoubleSafe(this IDataReader pReader, string pField) => pReader.GetDoubleSafe(pField, 0);

        /// <summary>
        /// Gets the record value cast as double or the specified default value.
        /// </summary>
        /// <param name = "pReader">The data reader.</param>
        /// <param name = "pField">The name of the record field.</param>
        /// <param name = "pDefaultValue">The default value.</param>
        /// <returns>The record value</returns>
        public static double GetDoubleSafe(this IDataReader pReader, string pField, long pDefaultValue)
        {
            var value = pReader[pField];
            return ((value is double) ? Convert.ToDouble(value) : pDefaultValue);
        }
        /// <summary>
        /// Gets the record value cast as DateTime or DateTime.MinValue.
        /// </summary>
        /// <param name = "pReader">The data reader.</param>
        /// <param name = "pField">The name of the record field.</param>
        /// <returns>The record value</returns>
        public static DateTime GetDateTimeSafe(this IDataReader pReader, string pField) => pReader.GetDateTimeSafe(pField, DateTime.MinValue);
        /// <summary>
        /// Gets the record value cast as DateTime or the specified default value.
        /// </summary>
        /// <param name = "pReader">The data reader.</param>
        /// <param name = "pField">The name of the record field.</param>
        /// <param name = "pDefaultValue">The default value.</param>
        /// <returns>The record value</returns>
        public static DateTime GetDateTimeSafe(this IDataReader pReader, string pField, DateTime pDefaultValue)
        {
            var value = pReader[pField];
            return ((value is DateTime) ? Convert.ToDateTime(value) : pDefaultValue);
        }
        /// <summary>
        /// Get value as string check for DBNull
        /// </summary>
        /// <param name="pReader"></param>
        /// <param name="pField"></param>
        /// <returns></returns>
        public static string GetStringSafe(this IDataReader pReader, string pField) => ((pReader[pField] is DBNull) ? null : pReader[pField].ToString());
    }
}
