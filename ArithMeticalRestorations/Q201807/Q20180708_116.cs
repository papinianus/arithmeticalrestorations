using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201807
{
    static class Q20180708_116
    {
        internal static void SolveQ1() // 177 4 708
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                foreach (var j in Enumerator.FromOneToNine())
                {
                    var first = (int)(new[] { i, 7, j, }).ToDecade();
                    foreach (var second in Enumerator.FromOneToNine())
                    {
                        var ans = first * second;
                        if (!ans.Is3digits() || ans % 100 != 8) { continue; }
                        Console.WriteLine($"{first} {second} {ans}");
                    }
                }
            }
        }
        internal static void SolveQ2() // 97 19 1843
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                var first = (int)(new[] { i, 7, }).ToDecade();
                foreach (var j in Enumerator.FromOneToNine())
                {
                    if (!(first * j).Is2digits()) { continue; }
                    foreach (var k in Enumerator.FromOneToNine())
                    {
                        if (!(first * k).Is3digits()) { continue; }
                        var second = (int)(new[] { j, k, }).ToDecade();
                        var ans = first * second;
                        if (!ans.IsX8XX()) { continue; }
                        Console.WriteLine($"{first} {second} {ans}");
                    }
                }
            }
        }
        internal static void SolveQ3() // 245 148 36260
        {
            foreach (var first in Enumerator.NumberInNdigits(3))
            {
                foreach (var k in Enumerator.FromOneToNine())
                {
                    if (!(first * k).IsXXX0()) { continue; }
                    foreach (var i in Enumerator.FromOneToNine())
                    {
                        if (!(first * i).IsX4X()) { continue; }
                        foreach (var j in Enumerator.FromOneToNine())
                        {
                            if (!(first * j).IsX8X()) { continue; }
                            var second = (int)(new[] { i, j, k, }).ToDecade();
                            var ans = first * second;
                            if (ans % 1000 != 260) { continue; }
                            Console.WriteLine($"{first} {second} {ans}");
                        }
                    }
                }
            }
        }
        internal static void SolveQ4() // 29 1837 53273
        {
            foreach (var nums in Enumerator.Permutations(Enumerator.FromZeroToNine(), 6))
            {
                var ni = nums.ElementAt(0);
                var hon = nums.ElementAt(1);
                var be = nums.ElementAt(2);
                var ru = nums.ElementAt(3);
                var gi = nums.ElementAt(4);
                var dash = nums.ElementAt(5);
                if (ni == 0 || be == 0) { continue; }
                var first = (int)(new[] { ni, hon, }).ToDecade();
                if (!(first * be).Is2digits()) { continue; }
                if (!(first * gi).Is2digits()) { continue; }
                if (!(first * ru).Is3digits()) { continue; }
                if (!(first * dash).Is3digits()) { continue; }
                var second = (int)(new[] { be, ru, gi, dash, }).ToDecade();
                var ans = first * second;
                if (!ans.Is5digits()) { continue; }
                if (ans % 1000 != (int)(new[] { 2, dash, 3 }).ToDecade()) { continue; }
                Console.WriteLine($"{first} {second} {ans}");
            }
        }
        internal static void SolveQ5() // 74116 4253 315215348
        {
            foreach (var first in Enumerator.NumberInNdigits(5))
            {
                foreach (var i in Enumerator.FromOneToNine())
                {
                    var lineI = first * i;
                    if (!lineI.IsXXXX64()) { continue; }
                    foreach (var j in Enumerator.FromOneToNine())
                    {
                        if (!(first * j).IsXX8XX2()) { continue; }
                        foreach (var k in Enumerator.FromOneToNine())
                        {
                            if (!(first * k).IsXX05XX()) { continue; }
                            foreach (var l in Enumerator.FromOneToNine())
                            {
                                var second = (int)(new[] { i, j, k, l, }).ToDecade();
                                var ans = first * second;
                                if (!ans.IsXXXXXX3XX()) { continue; }
                                var diffI = ans / 1000 - lineI;
                                if (!diffI.IsXX7XX()) { continue; }
                                var diffIJ = ans / 100 - first * (int)(new[] { i, j, }).ToDecade();
                                if (!diffIJ.IsX9XX1()) { continue; }
                                Console.WriteLine($"{first} {second} {ans}");
                            }
                        }
                    }
                }
            }
        }
    }
}
