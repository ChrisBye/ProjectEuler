using System.Collections.Generic;
using ProjectEulerCore.Infrastructure;
using System.Linq;
using System.Numerics;

namespace ProjectEulerCSharp
{
    [Problem(020, "Find the sum of the digits in the number 100!")]
    public class Solution020
    {
        public object BruteForce()
        {
            BigInteger fac = 1;
            foreach (var i in Enumerable.Range(1, 100))
            {
                fac *= i;
            }
            var digits = fac.ToString();
            return digits.Select(c => int.Parse(c.ToString())).Sum();
        }
    }
}
