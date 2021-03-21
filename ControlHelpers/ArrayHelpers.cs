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
        /// <typeparam name="TArray">type e.g. int, string etc</typeparam>
        /// <param name="sender">data</param>
        /// <returns>an array of T</returns>
        public static TArray[] ConcatArrays<TArray>(params TArray[][] sender)
        {
            var position = 0;
            var outputArray = new TArray[sender.Sum(a => a.Length)];
            
            foreach (var current in sender)
            {
                Array.Copy(current, 0, outputArray, position, current.Length);

                position += current.Length;
            }
            
            return outputArray;
        }
    }
}
