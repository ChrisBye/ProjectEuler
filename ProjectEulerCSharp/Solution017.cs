using System;
using System.Collections.Generic;
using ProjectEulerCore.Infrastructure;
using System.Linq;

namespace ProjectEulerCSharp
{
    [Problem(017, "If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?")]
    public class Solution017
    {
        public object Solve()
        {
            //this is a dumb problem
            return Enumerable.Range(1, 1000).Select(ToWord).Select(w=>w.Length).Sum();
        }

        private string ToWord(int i)
        {
            if (i == 1000)
                return "onethousand";
            var number = i.ToString().Reverse().Select(d=> (int)char.GetNumericValue(d)).Concat(Enumerable.Repeat(0,3)).Take(3).ToArray();

            var onespart = number[0];
            var tensPart = number[1];
            var hundredsPart = number[2];

            var hundredstring = hundredsPart == 0
                ? ""
                : ones[hundredsPart] + "hundred" + (tensPart != 0 || onespart != 0 ? "and" : "");
            var teensString = tensPart == 1 && onespart != 0 ? teens[onespart] : "";
            var tensString = teensString != "" ? "" :tens.ContainsKey(tensPart) ? tens[tensPart] : "";
            var onesString = teensString != "" ? "" : ones[onespart];

            return hundredstring + tensString + teensString + onesString;
        }
        private Dictionary<int, string> ones = new Dictionary<int, string>()
        {
            {0, ""},
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"},
            {6, "six"},
            {7, "seven"},
            {8, "eight"},
            {9, "nine"}
        };
        private Dictionary<int, string> teens = new Dictionary<int, string>()
        {
            {1, "eleven"},
            {2, "twelve"},
            {3, "thirteen"},
            {4, "fourteen"},
            {5, "fifteen"},
            {6, "sixteen"},
            {7, "seventeen"},
            {8, "eighteen"},
            {9, "nineteen"}
        };
        private Dictionary<int,string> tens= new Dictionary<int, string>()
        {
            {1,"ten"},
            {2,"twenty"},
            {3,"thirty"},
            {4,"forty"},
            {5,"fifty"},
            {6,"sixty"},
            {7,"seventy"},
            {8,"eighty"},
            {9,"ninety"}
        };
    }
}
