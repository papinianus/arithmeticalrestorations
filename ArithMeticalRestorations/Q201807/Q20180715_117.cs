using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201807
{
    static class Q20180715_117
    {
        internal static void SolveQ1() // 17 57 969
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                var first = (int)(new[] { i, 7, }).ToDecade();
                foreach (var j in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    if (!(first * j).IsX5()) { continue; }
                    foreach (var k in Enumerator.FromOneToNine())
                    {
                        if (!(first * k).IsX1X()) { continue; }
                        var second = (int)(new[] { j, k, }).ToDecade();
                        var ans = first * second;
                        Console.WriteLine($"{first} {second} {ans}");
                    }
                }
            }
        }
        internal static void SolveQ2() // 125 79 9875
        {
            foreach (var first in Enumerator.NumberInNdigits(3).Where(IntExtensions.IsOdd))
            {
                if (!(first * 7).IsXX5()) { continue; }
                foreach (var i in Enumerator.FromOneToNine())
                {
                    if (!(first * i).IsX1XX()) { continue; }
                    var second = (int)(new[] { 7, i, }).ToDecade();
                    var ans = first * second;
                    Console.WriteLine($"{first} {second} {ans}");
                }
            }
        }
        internal static void SolveQ3() // 1528 673 1028344
        {
            foreach (var first in Enumerator.NumberInNdigits(4))
            {
                if (!(first * 6).IsX1XX()) { continue; }
                foreach (var i in Enumerator.FromOneToNine())
                {
                    if (!(first * i).IsXXX9X()) { continue; }
                    foreach (var j in Enumerator.FromOneToNine())
                    {
                        if (!(first * j).IsXXX4()) { continue; }
                        var second = (int)(new[] { 6, i, j }).ToDecade();
                        var ans = first * second;
                        if (!ans.IsXXXX3XX()) { continue; }
                        Console.WriteLine($"{first} {second} {ans}");
                    }
                }
            }
        }
        internal static void SolveQ4() // 146309 55129 8065868861
        {
            foreach (var first in Enumerator.NumberInNdigits(6).Where(IntExtensions.IsOdd))
            {
                foreach (var k in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    if (!(first * k).IsXXX309()) { continue; }
                    foreach (var m in Enumerator.FromOneToNine())
                    {
                        if (!(first * m).IsXX167XX()) { continue; }
                        foreach (var l in Enumerator.FromOneToNine())
                        {
                            if (!(first * l).IsXX2XX8()) { continue; }
                            foreach (var i in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                            {
                                if (!(first * i).IsXXXXX5()) { continue; }
                                foreach (var j in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                                {
                                    if (!(first * j).IsXXXX4X()) { continue; }
                                    var second = (new[] { i, j, k, l, m, }).ToDecade();
                                    var ans = first * second;
                                    Console.WriteLine($"{first} {second} {ans}");
                                }
                            }
                        }
                    }
                }
            }
        }
        internal static void SolveQ5() // 
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
