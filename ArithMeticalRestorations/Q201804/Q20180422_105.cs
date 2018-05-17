using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201804
{
    static class Q20180422_105
    {
        internal static void SolveQ1() // 74 3 222
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                var first = (int)(new[] { i, 4 }).ToDecade();
                foreach (var j in Enumerator.FromOneToNine())
                {
                    var second = j;
                    var ans = first * second;
                    if (!ans.IsX22()) { continue; }
                    Console.WriteLine($"{first} {second} {ans}");
                }
            }
        }
        internal static void SolveQ2() // 14 19 266
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                var first = (int)(new[] { i, 4 }).ToDecade();
                foreach (var k in Enumerator.FromOneToNine())
                {
                    if (!(first * k).IsX2X()) { continue; }
                    foreach (var j in Enumerator.FromOneToNine())
                    {
                        if (!(first * j).Is2digits()) { continue; }
                        var second = (int)(new[] { j, k }).ToDecade();
                        var ans = first * second;
                        if (!ans.Is2XX()) { continue; }
                        Console.WriteLine($"{first} {second} {ans}");
                    }
                }
            }
        }
        internal static void SolveQ3() // 623 154 95942
        {
            foreach (var i in Enumerator.FromZeroToNine())
            {
                foreach (var j in Enumerator.FromZeroToNine())
                {
                    var first = (int)(new[] { 6, i, j }).ToDecade();
                    if (!(first * 4).IsXX9X()) { continue; }
                    foreach (var k in Enumerator.FromOneToNine())
                    {
                        if (!(first * k).IsXX3()) { continue; }
                        foreach (var l in Enumerator.FromOneToNine())
                        {
                            if (!(first * l).IsX1XX()) { continue; }
                            var second = (int)(new[] { k, l, 4 }).ToDecade();
                            var ans = first * second;
                            Console.WriteLine($"{first} {second} {ans}");
                        }
                    }
                }
            }
        }
        internal static void SolveQ4() // 95387 101255
        {
            foreach (var nums in Enumerator.Permutations(Enumerator.FromZeroToNine(), 8))
            {
                var a = nums.ElementAt(0);
                var i = nums.ElementAt(1);
                var u = nums.ElementAt(2);
                var e = nums.ElementAt(3);
                var o = nums.ElementAt(4);
                var ka = nums.ElementAt(5);
                var ni = nums.ElementAt(6);
                var wa = nums.ElementAt(7);
                var ans = 10000 * a + 2000 * i + 300 * u + 40 * e + 5 * o;
                if(!ans.Is6digits()) { continue; }
                var kanikawaii = (int)(new[] { ka, ni, ka, wa, i, i }).ToDecade();
                if (ans != kanikawaii) { continue; }
                Console.WriteLine($"{a}{i}{u}{e}{o} {ans}");
            }
        }
        internal static void SolveQ5() // 1781487 3861 6878321307
        {
            foreach (var first in Enumerator.NumberInNdigits(7))
            {
                foreach (var i in Enumerator.FromOneToNine())
                {
                    if (!(first * i).IsXXX4XX1()) { continue; }
                    foreach (var k in Enumerator.FromOneToNine())
                    {
                        if (!(first * k).IsXX6XX9XX()) { continue; }
                        foreach (var l in Enumerator.FromOneToNine())
                        {
                            if (!(first * l).IsX78XXXX()) { continue; }
                            foreach (var j in Enumerator.FromOneToNine())
                            {
                                if (!(first * j).IsXXX5XXXX()) { continue; }

                                var second = (new int[] { i, j, k, l }).ToDecade();
                                var ans = first * second;
                                if (!ans.IsXXXX32XXXX()) { continue; }
                                Console.WriteLine($"{first} {second} {ans}");
                            }
                        }
                    }
                }
            }
        }
    }
}
