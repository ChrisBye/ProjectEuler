using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEulerCSharp;

namespace ProjectEulerCore.Helpers
{
    public static class Math
    {
        public static List<long> PrimeFactorize(this long target)
        {
            var primes = Sequences.Primes().GetEnumerator();
            var factors = new List<long>();
            while (primes.MoveNext())
            {
                var candidate = primes.Current;
                if (candidate > target / 2)
                {
                    factors.Add(target);
                    break;
                }
                var remainder = target % candidate;
                var quotient = target / candidate;
                while (remainder == 0)
                {
                    target = quotient;
                    factors.Add(candidate);
                    remainder = target % candidate;
                    quotient = target / candidate;
                }
            }
            return factors;
        }
        public static List<long> PrimeFactorize(this int target)
        {
            return ((long) target).PrimeFactorize();
        }
    }
}