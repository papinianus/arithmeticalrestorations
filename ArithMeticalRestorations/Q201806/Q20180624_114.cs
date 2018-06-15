using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201806
{
    static class Q20180624_114
    {
        internal static void SolveQ1() // 54 6 324
        {
            foreach(var first in Enumerator.NumberInNdigits(2))
            {
                var second = 6;
                var ans = first * second;
                if (ans % 100 != 24) { continue; }
                Console.WriteLine($"{first} {second} {ans}");
            }
        }
        internal static void SolveQ2() // 12 52 624
        {
            foreach (var first in Enumerator.NumberInNdigits(2))
            {
                foreach (var i in Enumerator.FromOneToNine())
                {
                    if (!(first * i).Is2digits()) { continue; }
                    foreach (var j in Enumerator.FromOneToNine())
                    {
                        if (!(first * j).Is2digits()) { continue; }
                        var second = (int)(new[] { i, j, }).ToDecade();
                        var ans = first * second;
                        if (ans != 624) { continue; }
                        Console.WriteLine($"{first} {second} {ans}");
                    }
                }
            }
        }
        internal static void SolveQ3() // 457 259 118363
        {
            foreach (var first in Enumerator.NumberInNdigits(3))
            {
                foreach (var i in Enumerator.FromOneToNine())
                {
                    if (!(first * i).IsXX4()) { continue; }
                    foreach (var k in Enumerator.FromOneToNine())
                    {
                        if (!(first * k).IsXX13()) { continue; }
                        foreach (var j in Enumerator.FromOneToNine())
                        {
                            if (!(first * j).IsXXX5()) { continue; }
                            var second = (int)(new[] { i, j, k, }).ToDecade();
                            var ans = first * second;
                            if (!ans.Is6digits()) { continue; }
                            Console.WriteLine($"{first} {second} {ans}");
                        }
                    }
                }
            }
        }
        internal static void SolveQ4() // 2081141 9067 18869705447
        {
            foreach (var first in Enumerator.NumberInNdigits(7))
            {
                foreach (var j in Enumerator.FromOneToNine())
                {
                    if (!(first * j).IsX24X68XX()) { continue; }
                    foreach (var k in Enumerator.FromOneToNine())
                    {
                        if (!(first * k).Is1X5X7XXX()) { continue; }
                        foreach (var i in Enumerator.FromOneToNine())
                        {
                            if (!(first * i).IsXXX3XXX9()) { continue; }
                            var second = (new[] { i, 0, j, k, }).ToDecade();
                            var ans = first * second;
                            Console.WriteLine($"{first} {second} {ans}");
                        }
                    }
                }
            }
        }
        internal static void SolveQ5() // 17240 2787 48047880
        {
            foreach (var first in Enumerator.NumberInNdigits(5))
            {
                foreach (var j in Enumerator.FromOneToNine())
                {
                    if(!(first * j).IsX2X68X()) { continue; }
                    foreach(var i in Enumerator.FromOneToNine())
                    {
                        var lineI = first * i;
                        if (!lineI.IsX4XX0()) { continue; }
                        foreach (var k in Enumerator.FromOneToNine())
                        {
                            if (!(first * k).Is1XXXXX()) { continue; }
                            foreach (var l in Enumerator.FromOneToNine())
                            {
                                if (!(first * l).Is6digits()) { continue; }
                                var second = (int)(new int[] { i, j, k, l, }).ToDecade();
                                var ans = first * second;
                                var diffI = (ans / 1000) - lineI;
                                if (!diffI.IsX35X7()) { continue; }
                                Console.WriteLine($"{first} {second} {ans}");
                            }
                        }
                    }
                }
            }
        }
    }
}
