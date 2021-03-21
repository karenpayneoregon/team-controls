﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamHelpers
{
    /// <summary>
    /// Set of helpers to convert between data types and notations.
    /// </summary>
    /// <remarks>
    /// https://github.com/windows-toolkit/WindowsCommunityToolkit/blob/master/Microsoft.Toolkit/Converters.cs
    /// </remarks>
    public static class Converters
    {
        /// <summary>
        /// Translate numeric file size in bytes to a human-readable shorter string format.
        /// </summary>
        /// <param name="size">File size in bytes.</param>
        /// <returns>Returns file size short string.</returns>
        public static string ToFileSizeString(long size)
        {
            if (size < 1024)
            {
                return size.ToString("F0") + " bytes";
            }
            else if ((size >> 10) < 1024)
            {
                return (size / 1024F).ToString("F1") + " KB";
            }
            else if ((size >> 20) < 1024)
            {
                return ((size >> 10) / 1024F).ToString("F1") + " MB";
            }
            else if ((size >> 30) < 1024)
            {
                return ((size >> 20) / 1024F).ToString("F1") + " GB";
            }
            else if ((size >> 40) < 1024)
            {
                return ((size >> 30) / 1024F).ToString("F1") + " TB";
            }
            else if ((size >> 50) < 1024)
            {
                return ((size >> 40) / 1024F).ToString("F1") + " PB";
            }
            else
            {
                return ((size >> 50) / 1024F).ToString("F0") + " EB";
            }
        }
    }
}
