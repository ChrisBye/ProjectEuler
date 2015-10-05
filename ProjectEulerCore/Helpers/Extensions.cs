using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerCore.Helpers
{
    public static class Extensions
    {
        public static string ToCsl<T>(this IEnumerable<T> enumerable)
        {
            return String.Join(",", enumerable.Select(i => i.ToString()).ToArray());
        }

        public static long Product(this IEnumerable<long> factors)
        {
            return factors.Aggregate(1L, (current, factor) => current*factor);
        }
        public static long Product(this IEnumerable<int> factors)
        {
            return factors.Aggregate(1L, (current, factor) => current * factor);
        }
        public static double Product(this IEnumerable<double> factors)
        {
            return factors.Aggregate(1.0, (current, factor) => current * factor);
        }
        public static bool IsPalindrome(this object val)
        {
            var str = val.ToString();
            var objB = new string (str.Reverse().ToArray());
            var isPalindrome = Equals(str, objB);
            return isPalindrome;
        }

        //private static bool IsPalindrome(this struct val)
        //{
            
        //}
    }
}