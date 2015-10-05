using System.Collections.Generic;
using System.Linq;
using ProjectEulerCore.Infrastructure;

namespace ProjectEulerCSharp
{
    [Problem(2, "Even Fibonacci numbers")]
    public class Solution002
    {
        public object Solve()
        {
            var solution = Sequences.Fibbonacci().TakeWhile(n => n < 4000000).Where(n => n%2 ==0).Sum()  ;
            return solution;
        }
    }
}
