using System.Collections.Generic;
using ProjectEulerCore.Infrastructure;
using System.Linq;

namespace ProjectEulerCSharp
{
    [Problem(7, "What is the 10 001st prime number?")]
    public class Solution007
    {
        public object Solve()
        {
            var solution = Sequences.Primes().ElementAt(10000);
            return solution;
        }
    }
}
