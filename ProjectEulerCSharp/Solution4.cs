using System.Collections.Generic;
using System.Linq;
using ProjectEulerCore.Helpers;
using ProjectEulerCore.Infrastructure;

namespace ProjectEulerCSharp
{
    [Problem(4, "Find the largest palindrome made from the product of two 3-digit numbers.")]
    public class Solution4
    {
        public object Solve()
        {
            var outer = Enumerable.Range(1, 999).Reverse();
            var largest = 1;
            var s = 9009.IsPalindrome();
            foreach (var i in outer)
            {
                var inner = Enumerable.Range(1, i).Reverse();
                foreach (var j in inner)
                {
                    var product = i*j;
                    if (product.IsPalindrome())
                    {
                        if (product > largest)
                            largest = product;
                        break;
                    }
                }
            }

            var solution = largest;
            return solution;
        }

    }
}
