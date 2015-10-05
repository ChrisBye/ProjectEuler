using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;
using ProjectEulerCore.Helpers;
using ProjectEulerCore.Infrastructure;
using Math = System.Math;

namespace ProjectEulerCSharp
{
    [Problem(5, "What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?")]
    public class Solution005
    {
        public object Solve()
        {
            var factorizations = Enumerable.Range(1, 20).Select(FactorCounts);
            
            Dictionary<long, int> largestCounts = new Dictionary<long, int>();
            
            foreach (var factorization in factorizations)
            {
                foreach (var factor in factorization.Keys)
                {
                    if (!largestCounts.ContainsKey(factor) || factorization[factor] > largestCounts[factor])
                    {
                        largestCounts[factor] = factorization[factor];
                    }
                }
            }


            return largestCounts.Select(kvp => Math.Pow(kvp.Key, kvp.Value)).Product();
        }

        private static Dictionary<long, int> FactorCounts(int i)
        {
            var factors = i.PrimeFactorize();
            return factors.Distinct().ToDictionary(f=> f, f => factors.Count(g => g ==f));
        }
    }
}
