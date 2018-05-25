using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201803
{
    static class Q20180311_100
    {
        internal static void SolveQ1() // 73 7 511
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                var first = (int)(new[] { i, 3 }).ToDecade();
                foreach (var j in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    var second = j;
                    var ans = first * second;
                    if(!ans.IsX11()) { continue; }
                    Console.WriteLine($"{first} {second} {ans}");
                }
            }
        }
        internal static void SolveQ2() // 31 36 1116
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                var first = (int)(new[] { 3, i }).ToDecade();
                foreach (var k in Enumerator.FromOneToNine())
                {
                    if(!(first * k).Is1XX()) { continue; }
                    foreach (var j in Enumerator.FromOneToNine())
                    {
                        if (!(first * j).Is2digits()) { continue; }
                        var second = (int)(new[] { j, k, }).ToDecade();
                        var ans = first * second;
                        if (!ans.IsXX1X()) { continue; }
                        Console.WriteLine($"{first} {second} {ans}");
                    }
                }
            }
        }
        internal static void SolveQ3() // 1349 79195 106834055
        {
            foreach (var first in Enumerator.NumberInNdigits(4).Where(IntExtensions.IsOdd))
            {
                foreach (var k in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    if (!(first * k).IsXXX9()) { continue; }
                    foreach (var i in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                    {
                        if (!(first * i).IsXXX3()) { continue; }
                        foreach (var j in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                        {
                            if (!(first * j).IsXXXX1()) { continue; }
                            foreach (var l in Enumerator.FromOneToNine())
                            {
                                if (!(first * l).IsXXX4X()) { continue; }
                                foreach (var m in Enumerator.FromOneToNine())
                                {
                                    if (!(first * m).Is6XXX()) { continue; }
                                    var second = (int)(new[] { i, j, k, l, m, }).ToDecade();
                                    var ans = first * second;
                                    if(!ans.Is9digits()) { continue; }
                                    Console.WriteLine($"{first} {second} {ans}");
                                }
                            }
                        }
                    }
                }
            }
        }
        internal static void SolveQ4() // 23152 35128 813283456
        {
            foreach (var first in Enumerator.NumberInNdigits(5))
            {
                foreach(var m in Enumerator.FromOneToNine())
                {
                    if(!(first * m).IsXXX21X()) { continue; }
                    foreach(var l in Enumerator.FromOneToNine())
                    {
                        if (!(first * l).IsXX3XX()) { continue; }
                        foreach (var k in Enumerator.FromOneToNine())
                        {
                            if (!(first * k).IsXXX5X()) { continue; }
                            foreach (var j in Enumerator.FromOneToNine())
                            {
                                if (!(first * j).IsXXX7XX()) { continue; }
                                foreach (var i in Enumerator.FromOneToNine())
                                {
                                    var lineI = first * i;
                                    if (!lineI.IsX9XXX()) { continue; }
                                    var second = (int)(new[] { i, j, k, l, m, }).ToDecade();
                                    var ans = first * second;
                                    if (!ans.Is9digits()) { continue; }
                                    if (!((ans / 10000) - lineI).IsXX8XX()) { continue; }
                                    if (!((ans / 1000) - (first * (int)(new[]{i, j}).ToDecade())).IsXX6X()) { continue; }
                                    Console.WriteLine($"{first} {second} {ans}");
                                }
                            }
                        }
                    }
                }
            }
        }
        internal static void SolveQ5() // 2435271 8319 20259019449
        {
            foreach (var first in Enumerator.NumberInNdigits(7).Where(IntExtensions.IsOdd))
            {
                foreach (var j in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    if(!(first * j).Is7XX5XX3()) { continue; }
                    foreach(var i in Enumerator.FromOneToNine())
                    {
                        if (!(first * i).IsXXX8XX6X()) { continue; }
                        foreach (var k in Enumerator.FromOneToNine())
                        {
                            if (!(first * k).IsX4XX2XX()) { continue; }
                            foreach (var l in Enumerator.FromOneToNine())
                            {
                                if (!(first * l).IsXXX1XXXX()) { continue; }
                                var second = (new int[] { i, j, k, l, }).ToDecade();
                                var ans = first * second;
                                if (!ans.IsXXXX9XXXXXX()) { continue; }
                                Console.WriteLine($"{first} {second} {ans}");
                            }
                        }
                    }
                }
            }
        }
    }
}
