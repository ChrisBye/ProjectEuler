using System;
using System.Collections.Generic;
using ProjectEulerCore.Infrastructure;
using System.Linq;

namespace ProjectEulerCSharp
{
    [Problem(9, "There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc.")]
    public class Solution9
    {
        public object Solve()
        {
            var @as = Enumerable.Range(1, 400);
            var bs = Enumerable.Range(1, 400);

            foreach (var a in @as)
            {
                foreach (var b in bs)
                {
                    var c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    if (Math.Abs(a + b + c - 1000) < .0001)
                        return a*b*c;
                }
            }
            var solution = "solution not found";
            return solution;
        }
    }
}
