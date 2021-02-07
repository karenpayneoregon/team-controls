using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamHelpers
{
    public class ArrayHelpers
    {
        /// <summary>
        /// Concatenate arrays
        /// </summary>
        /// <typeparam name="T">type e.g. int, string etc</typeparam>
        /// <param name="sender">data</param>
        /// <returns>an array of T</returns>
        public static T[] ConcatArrays<T>(params T[][] sender)
        {
            var position = 0;
            var outputArray = new T[sender.Sum(a => a.Length)];
            
            foreach (var current in sender)
            {
                Array.Copy(current, 0, outputArray, position, current.Length);

                position += current.Length;
            }
            
            return outputArray;
        }
    }
}
