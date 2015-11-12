using System.Collections.Generic;
using ProjectEulerCore.Infrastructure;
using System.Linq;
using System.Numerics;

namespace ProjectEulerCSharp
{
    [Problem(16, "Power digit sum")]
    public class Solution016
    {
        public object Solve()
        {
            BigInteger number = BigInteger.Pow(2, 1000);
            var total = 0;
            while (number > 0)
            {
                total += (int)(number % 10);
                number = number/10;
            }
            
            return total;
        }
    }
}
