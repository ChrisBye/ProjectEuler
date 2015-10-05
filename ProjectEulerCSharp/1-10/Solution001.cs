using System;
using System.Linq;
using MoreLinq;
using ProjectEulerCore.Infrastructure;

namespace ProjectEulerCSharp
{
    [Problem(1, "Add all the natural numbers below one thousand that are multiples of 3 or 5.")]
    public class Solution001
    {
        public string SolveBruteForce()
        {
            var solution = Enumerable.Range(1, 999).Where(i => i%3 == 0 || i%5 == 0).Sum();
            return solution.ToString();
        }

        //public string SolveEfficient()
        //{
        //}

        //public object SolveGenerateByIndex()
        //{
        //}
    }
}
