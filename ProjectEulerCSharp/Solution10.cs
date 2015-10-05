using System.Collections.Generic;
using ProjectEulerCore.Infrastructure;
using System.Linq;

namespace ProjectEulerCSharp
{
    [Problem(10, "Find the sum of all the primes below two million.")]
    public class Solution10
    {
        public object Solve()
        {
            var solution = Sequences.Primes().TakeWhile(i => i < 2000000).Sum();
            return solution;
        }
    }
}
