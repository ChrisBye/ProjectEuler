using System.Collections.Generic;
using ProjectEulerCore.Infrastructure;
using System.Linq;
using System;
using System.IO;

namespace ProjectEulerCSharp
{
    [Problem(022, "Description")]
    public class Solution022
    {
        public object Solve()
        {
            var names = GetNames().OrderBy(s=>s).Select((s,i) => (i+1)*AlphaValue(s)).Sum();
            return names;
        }

        private IEnumerable<string> GetNames()
        {
            var fs = File.OpenText(@"G:\git\ProjectEuler\ProjectEulerCore\Assets\p022_names.txt");
            var raw = fs.ReadToEnd();
            var words = raw.Split(',').Select(w => w.Trim('"'));
            return words;
        }
        private static int AlphaValue(this string s)
        {
            //A=65
            return s.Select(c => c - 'A' + 1).Sum();
        }
    }
}
