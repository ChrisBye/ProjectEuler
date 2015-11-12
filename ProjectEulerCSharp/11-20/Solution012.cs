using System;
using System.Collections.Generic;
using ProjectEulerCore.Infrastructure;
using System.Linq;
using ProjectEulerCore.Helpers;

namespace ProjectEulerCSharp
{
    [Problem(12, "What is the value of the first triangle number to have over five hundred divisors?")]
    public class Solution012
    {
        public object Solve()
        {
            var number = Sequences.Triangle().First(i => i.Divisors().Count > 500);
            
            return number;
        }
    }
}
