using System.Collections.Generic;
using ProjectEulerCore.Infrastructure;
using System.Linq;
using ProjectEulerCore.Helpers;

namespace ProjectEulerCSharp
{
    [Problem(15, "Lattice paths")]
    public class Solution015
    {
        public object Solve()
        {
            /*
             * right moves and down moves can map to 0s and 1s
             * a path that goes 20 down and 20 right is 40 bits long and has 20 1s and 20 0s             
             * this is the same as 40 choose 20 since we're picking 20 bit-indicies to turn on
             * 
             */
            return Math.BinomialCoefficient(40, 20);

        }
    }
}
