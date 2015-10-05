using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEulerCore.Helpers;
using ProjectEulerCore.Infrastructure;

namespace ProjectEulerCSharp
{
    [Problem(3, "Largest prime factor of 600851475143 ")]
    public class Solution3
    {
        public object Solve()
        {

            var primes = Sequences.Primes().GetEnumerator();

            var factors = new List<long>();
            var target = 600851475143;
            while (primes.MoveNext())
            {
                var candidate = primes.Current;
                if (candidate > target/2)
                {
                    factors.Add(target);
                    return factors.Last();
                }
                var remainder = target%candidate;
                var quotient = target/candidate;
                while (remainder == 0)
                {
                    target = quotient;
                    factors.Add(candidate);
                    remainder = target % candidate;
                    quotient = target / candidate;
                }
            }

            return null;
        }

        
    }
}

