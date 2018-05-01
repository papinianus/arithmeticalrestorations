using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201804
{
    static class Q20180429_106
    {
        internal static void SolveQ1()
        {
            foreach(var i in Enumerator.FromOneToNine())
            {
                foreach (var j in Enumerator.FromOneToNine())
                {
                    var sum = (new[] { i, 4 }).ToDecade() * j;
                    if (sum / 10 == 29) { Console.WriteLine($"{i}4 {j} {sum}"); }
                }
            }
        }
    }
}
