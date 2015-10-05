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

        public static HashSet<long> Divisors(this long number)
        {
            var factors = new HashSet<long>();
            foreach (var candidate in Enumerable.Range(1,(int) System.Math.Floor(System.Math.Sqrt(number))))
            {
                if (number%candidate == 0)
                {
                    factors.Add(candidate);
                    factors.Add(number/candidate);
                }
            }
            return factors;
        }

        static int SparseBitcount(int n)
        {
            return SparseBitcount((long)n);
        }

        static int SparseBitcount(long n)
        {
            int count = 0;
            while (n != 0)
            {
                count++;
                n &= (n - 1);
            }
            return count;
        }

        public static long BinomialCoefficient(long n, long k)
        {
            //http://stackoverflow.com/a/12992171
            // This function gets the total number of unique combinations based upon N and K.
            // N is the total number of items.
            // K is the size of the group.
            // Total number of unique combinations = N! / ( K! (N - K)! ).
            // This function is less efficient, but is more likely to not overflow when N and K are large.
            // Taken from:  http://blog.plover.com/math/choose.html
            //
            long r = 1;
            long d;
            if (k > n) return 0;
            for (d = 1; d <= k; d++)
            {
                r *= n--;
                r /= d;
            }
            return r;
        }
    }
}