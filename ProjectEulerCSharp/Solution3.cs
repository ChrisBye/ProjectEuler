using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEulerCore.Helpers;
using ProjectEulerCore.Infrastructure;
using Math = ProjectEulerCore.Helpers.Math;

namespace ProjectEulerCSharp
{
    [Problem(3, "Largest prime factor of 600851475143 ")]
    public class Solution3
    {
        public object Solve()
        {
            long target = 600851475143; 
            var factors = Math.PrimeFactorize(target);
            return factors.Last();

        }
    }
}

