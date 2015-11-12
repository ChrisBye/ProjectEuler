using System.Collections.Generic;
using ProjectEulerCore.Infrastructure;
using System.Linq;
using System;
using ProjectEulerCore.Helpers;
using System.IO;
using Math = ProjectEulerCore.Helpers.Math;

namespace ProjectEulerCSharp
{
    [Problem(024, "What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?")]
    public class Solution024
    {
        /// <summary>
        /// the first 9p9 permutations start with 0, the next 9p9 start with 1, and so on.
        /// </summary>
        /// <returns></returns>
        public object Solve()
        {
            var total = 1e6 -1; //fuck you OBOE
            var digits = Enumerable.Range(0, 10).Select(i => i.ToString()).ToList();
            
            var solution = "";
            while (digits.Any())
            {
                var numPermuting = digits.Count - 1;
                var permutations = Math.P(numPermuting, numPermuting);
                var nextDigitIndex = (int) System.Math.Floor(total/permutations);

                solution += digits[nextDigitIndex];
                digits.RemoveAt(nextDigitIndex);

                total = total%permutations;
            }
            return solution;
        }

        
    }
}
