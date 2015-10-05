using System;
using System.Collections.Generic;
using ProjectEulerCore.Infrastructure;
using System.Linq;

namespace ProjectEulerCSharp
{
    [Problem(6, "Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.")]
    public class Solution006
    {
        public object Solve()
        {
            var squareOfSum = Math.Pow(Enumerable.Range(1, 100).Sum(),2);
            var sumOfSquares = Enumerable.Range(1, 100).Select(i => Math.Pow(i,2)).Sum();
            var solution = squareOfSum - sumOfSquares;
            return solution;
        }
    }
}
