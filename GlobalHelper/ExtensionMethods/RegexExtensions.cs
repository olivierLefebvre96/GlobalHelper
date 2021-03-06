﻿using System.Text.RegularExpressions;

namespace GlobalHelper.ExtensionMethods
{
    public static class RegexExtensions
    {
        /// <summary>
        /// Counts the number of expressions found in the input string
        /// </summary>
        /// <param name="input">The input string to parse</param>
        /// <param name="search">The pattern to find</param>
        /// <returns>The number of occurrences found</returns>
        public static int Occurrence(this string input, string search) => Regex.Matches(input, search).Count;
    }
}
