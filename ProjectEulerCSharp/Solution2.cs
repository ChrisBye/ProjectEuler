using System.Collections.Generic;
using System.Linq;
using ProjectEulerCore.Infrastructure;

namespace ProjectEulerCSharp
{
    [Problem(2, "Even Fibonacci numbers")]
    public class Solution2
    {
        public object Solve()
        {
            var solution = Fibbonacci().TakeWhile(n => n < 4000000).Where(n => n%2 ==0).Sum()  ;
            return solution;
        }

        private IEnumerable<long> Fibbonacci()
        {
            int first = 0, second = 1;

            yield return 0;
            yield return 1;
            while (true)
            {
                int sum = first + second;
                first = second;
                second = sum;
                yield return second;
            }
        }
    }
}
