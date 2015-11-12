using System.Collections.Generic;
using ProjectEulerCore.Infrastructure;
using System.Linq;

namespace ProjectEulerCSharp
{
    [Problem(14, "Longest Collatz sequence")]
    public class Solution014
    {
        public object Solve()
        {

            var max = -1;
            var solution = -1;

            foreach (var i in Enumerable.Range(1, 1000000))
            {
                var collatz = Sequences.Collatz(i);
                var count = collatz.Count();
                if (count > max)
                {
                    max = count;
                    solution = i;
                }
            }
            

            return solution;
        }
    }
}
