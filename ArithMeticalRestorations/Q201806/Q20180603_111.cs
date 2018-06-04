using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201806
{
    static class Q20180603_111
    {
        internal static void SolveQ1() // 67 9 603
        {
            foreach (var first in Enumerator.NumberInNdigits(2).Where(IntExtensions.IsOdd))
            {
                foreach (var i in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    var second = i;
                    var ans = first * second;
                    if (ans != 603) { continue; }
                    Console.WriteLine($"{first} {second} {ans}");
                }
            }
        }
        internal static void SolveQ2() // 63 11 693
        {
            foreach (var i in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
            {
                var first = (int)(new[] { 6, i, }).ToDecade();
                foreach (var j in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    if (!(first * j).IsX3()) { continue; }
                    foreach (var k in Enumerator.FromOneToNine())
                    {
                        if (!(first * k).Is2digits()) { continue; }
                        var second = (int)(new[] { j, k, }).ToDecade();
                        var ans = first * second;
                        if (!ans.Is3digits()) { continue; }
                        Console.WriteLine($"{first} {second} {ans}");
                    }
                }
            }
        }
        internal static void SolveQ3() // 1846 497 917462
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                foreach (var j in Enumerator.FromOneToNine())
                {
                    foreach (var k in Enumerator.FromOneToNine())
                    {
                        var first = (int)(new[] { i, j, k, 6, }).ToDecade();
                        if (!(first * 4).IsX3XX()) { continue; }
                        foreach (var l in Enumerator.FromOneToNine())
                        {
                            if (!(first * l).IsXXX1X()) { continue; }
                            foreach (var m in Enumerator.FromOneToNine())
                            {
                                if (!(first * m).IsXX9XX()) { continue; }
                                var second = (int)(new[] { 4, l, m, }).ToDecade();
                                var ans = first * second;
                                Console.WriteLine($"{first} {second} {ans}");
                            }
                        }
                    }
                }
            }
        }
        internal static void SolveQ4() // 1111111 1555551 1544451 1546451 9968677
        {
            foreach (var nums in Enumerator.Permutations(Enumerator.FromZeroToNine(), 7))
            {
                var a = nums.ElementAt(0);
                var b = nums.ElementAt(1);
                var c = nums.ElementAt(2);
                var d = nums.ElementAt(3);
                var e = nums.ElementAt(4);
                var f = nums.ElementAt(5);
                var g = nums.ElementAt(6);
                if (7 * a > 9) { continue; }
                if (7 * a % 10 != g) { continue; }
                var line1 = (int)(new[] { a, a, a, a, a, a, a, }).ToDecade();
                var line2 = (int)(new[] { a, b, b, b, b, b, a, }).ToDecade();
                var line3 = (int)(new[] { a, b, c, c, c, b, a, }).ToDecade();
                var line4 = (int)(new[] { a, b, c, d, c, b, a, }).ToDecade();
                var sum = line1 + line2 + line3 + line4 + line3 + line2 + line1;
                var ans = (int)(new[] { e, e, d, f, d, g, g, }).ToDecade();
                if (sum != ans) { continue; }
                Console.WriteLine($"{line1} {line2} {line3} {line4} {ans}");
            }
        }
        internal static void SolveQ5() // 707823 97835 69249863205
        {
            foreach (var first in Enumerator.NumberInNdigits(6))
            {
                foreach (var l in Enumerator.FromOneToNine())
                {
                    if(!(first * l).IsX1234XX()) { continue; }
                    foreach(var i in Enumerator.FromOneToNine())
                    {
                        if (!(first * i).IsXXX0XX7()) { continue; }
                        foreach (var j in Enumerator.FromOneToNine())
                        {
                            if (!(first * j).IsXXXXX6X()) { continue; }
                            foreach (var k in Enumerator.FromOneToNine())
                            {
                                if (!(first * k).IsXXXX5XX()) { continue; }
                                foreach (var m in Enumerator.FromOneToNine())
                                {
                                    if (!(first * m).Is7digits()) { continue; }

                                    var second = (new int[] { i, j, k, l,m, }).ToDecade();
                                    var ans = first * second;
                                    if (!ans.IsXXXX98XXXXX()) { continue; }
                                    Console.WriteLine($"{first} {second} {ans}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
