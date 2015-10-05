using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerCSharp
{
    public class Sequences
    {
        #region primes
        /// <summary>
        /// https://handcraftsman.wordpress.com/2010/09/02/ienumerable-of-prime-numbers-in-csharp/
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<long> Primes()
        {
            yield return 2; //not really sure why it was not including 2, but now it is.
            var memoized = new List<long>();
            long sqrt = 1;
            var primes = PotentialPrimes().Where(x =>
            {
                sqrt = GetSqrtCeiling(x, sqrt);
                return !memoized
                    .TakeWhile(y => y <= sqrt)
                    .Any(y => x % y == 0);
            });
            foreach (long prime in primes)
            {
                yield return prime;
                memoized.Add(prime);
            }
        }

        private static long GetSqrtCeiling(long value, long start)
        {
            while (start * start < value)
            {
                start++;
            }
            return start;
        }

        private static IEnumerable<long> PotentialPrimes()
        {
            yield return 3L;
            long k = 1L;
            while (k > 0L)
            {
                yield return 6 * k - 1;
                yield return 6 * k + 1;
                k++;
            }
        }
        #endregion

        public static IEnumerable<long> Fibbonacci()
        {
            long first = 0L, second = 1L;

            yield return 0;
            yield return 1;
            while (true)
            {
                long sum = first + second;
                first = second;
                second = sum;
                yield return second;
            }
        }

        public static IEnumerable<int> InfiniteInt
        {
            get
            {
                int value = 0;
                while (true)
                {
                    yield return value++;
                }
            }
        }

        /// http://en.wikipedia.org/wiki/Arithmetic_progression#Sum
        public static int Arithmetic(int firstTerm, int increment, int termCount)
        {
            int lastTerm = increment * (termCount - 1) + firstTerm;
            decimal sum = ((decimal)termCount / 2) * (firstTerm + lastTerm);
            return (int)sum;
        }

    }
}