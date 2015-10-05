using System;
using System.Collections.Generic;
using ProjectEulerCore.Infrastructure;
using System.Linq;
using ProjectEulerCore.Helpers;

namespace ProjectEulerCSharp
{
    [Problem(021, "Evaluate the sum of all the amicable numbers under 10000.")]
    public class Solution021
    {
        public object Solve()
        {
            var ds = Sequences.InfiniteInt().Take(10000).ToDictionary(i => i, d);
            return Sequences.InfiniteInt().Take(10000).Where(i => Predicate(ds, i)).Sum();
        }

        private static  bool Predicate(Dictionary<int, int> ds, int a)
        {
            if (!ds.ContainsKey(a))
                return false;
            var d_a = ds[a];
            if (!ds.ContainsKey(d_a))
                return false;
            var d_d_a = ds[d_a];
            if (d_a != a && d_d_a == a)
                return true;
            return false;

        }

        private int d(int n)
        {
            return (int) ((long)n).ProperDivisors().Sum();
        }
    }

}
