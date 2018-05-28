using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201805
{
    static class Q20180527_110
    {
        internal static void SolveQ1() // 257 1 257
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                foreach (var j in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    var first = (int)(new[] { i, 5, j}).ToDecade();
                    foreach (var k in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                    {
                        var second = k;
                        var ans = first * second;
                        if (!ans.Is2X7()) { continue; }
                        Console.WriteLine($"{first} {second} {ans}");
                    }
                }
            }
        }
        internal static void SolveQ2() // 15 58 870
        {
            foreach(var first in Enumerator.NumberInNdigits(2))
            {
                if (!(first * 5).Is2digits()) { continue; }
                foreach (var i in Enumerator.FromOneToNine())
                {
                    if (!(first * i).IsX2X()) { continue; }
                    var second = (int)(new[] { 5, i, }).ToDecade();
                    var sum = first * second;
                    if (!sum.IsX7X()) { continue; }
                    Console.WriteLine($"{first} {second} {sum}");
                }
            }
        }
        internal static void SolveQ3() // 138 976 134688
        {
            foreach (var first in Enumerator.NumberInNdigits(3))
            {
                foreach (var i in Enumerator.FromOneToNine())
                {
                    var lineI = first * i;
                    if (!lineI.IsXXX2()) { continue; }
                    foreach (var j in Enumerator.FromOneToNine())
                    {
                        if (!(first * j).IsX6X()) { continue; }
                        foreach (var k in Enumerator.FromOneToNine())
                        {
                            if (!(first * k).Is8XX()) { continue; }
                            var second = (int)(new[] { i, j, k, }).ToDecade();
                            var ans = first * second;
                            var diffI = ans / 100 - lineI;
                            if(!diffI.IsXX4()) { continue; }
                            Console.WriteLine($"{first} {second} {ans}");
                        }
                    }
                }
            }
        }
        internal static void SolveQ4() // 3892241 973 3787150493
        {
            foreach (var first in Enumerator.NumberInNdigits(7).Where(IntExtensions.IsOdd))
            {
                foreach (var j in Enumerator.FromOneToNine())
                {
                    if (!(first * j).IsXX24568X()) { continue; }
                    foreach (var i in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                    {
                        if (!(first * i).IsXXX3XXX9()) { continue; }
                        foreach (var k in Enumerator.FromOneToNine())
                        {
                            if (!(first * k).IsX1XXX7XX()) { continue; }
                            var second = (new int[] { i, j, k, }).ToDecade();
                            var ans = first * second;
                            Console.WriteLine($"{first} {second} {ans}");
                        }
                    }
                }
            }
        }
        internal static void SolveQ5() // 56928 7279 414378912
        {
            foreach (var first in Enumerator.NumberInNdigits(5))
            {
                foreach (var l in Enumerator.FromOneToNine())
                {
                    if(!(first * l).IsX123XX()) { continue; }
                    foreach(var i in Enumerator.FromOneToNine())
                    {
                        if (!(first * i).IsXXXXX6()) { continue; }
                        foreach (var j in Enumerator.FromOneToNine())
                        {
                            if (!(first * j).IsXXXX5X()) { continue; }
                            foreach (var k in Enumerator.FromOneToNine())
                            {
                                if (!(first * k).IsXXX4XX()) { continue; }
                                var second = (int)(new int[] { i, j, k, l, }).ToDecade();
                                var ans = first * second;
                                if (!ans.IsXXXX789XX()) { continue; }
                                Console.WriteLine($"{first} {second} {ans}");
                            }
                        }
                    }
                }
            }
        }
    }
}
