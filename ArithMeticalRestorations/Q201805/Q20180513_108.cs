using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201805
{
    static class Q20180513_108
    {
        internal static void SolveQ1() // 51 81 4131
        {
            foreach (var i in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
            {
                var first = (int)(new[] { 5, i }).ToDecade();
                foreach (var k in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    if (!(first * k).IsX1()) { continue; }
                    foreach (var j in Enumerator.FromOneToNine())
                    {
                        if (!(first * j).Is3digits()) { continue; }
                        var second = (int)(new[] { j, k }).ToDecade();
                        var sum = first * second;
                        if(!sum.IsXX3X()) { continue; }
                        Console.WriteLine($"5{i} {j}{k} {sum}");
                    }
                }
            }
        }
        internal static void SolveQ2() // 197 56 11032
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                foreach (var j in Enumerator.FromZeroToNine())
                {
                    foreach (var k in Enumerator.FromZeroToNine())
                    {
                        var first = (int)(new[] { i, j, k }).ToDecade();
                        if(!(first * 5).Is3digits()) { continue; }
                        foreach (var l in Enumerator.FromZeroToNine())
                        {
                            if (!(first * l).IsX1XX()) { continue; }
                            var second = (int)(new[] { 5, l }).ToDecade();
                            var sum = first * second;
                            if (!sum.IsXXX3X()) { continue; }
                            Console.WriteLine($"{first} {second} {sum}");
                        }
                    }
                }
            }
        }
        internal static void SolveQ3() // 173 256 44288
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                foreach (var j in Enumerator.FromZeroToNine())
                {
                    foreach (var k in Enumerator.FromZeroToNine())
                    {
                        var first = (int)(new[] { i, j, k }).ToDecade();
                        foreach (var l in Enumerator.FromOneToNine())
                        {
                            if (!((first * l)).IsX4X()) { continue; }
                            foreach (var m in Enumerator.FromOneToNine())
                            {
                                if (!((first * m)).Is8XX()) { continue; }
                                foreach (var n in Enumerator.FromOneToNine())
                                {
                                    if (!((first * n)).IsX0XX()) { continue; }
                                    var second = (int)(new[] { l, m, n }).ToDecade();
                                    var sum = first * second;
                                    if(!sum.IsXX2XX()) { continue; }
                                    var diff1 = ((sum / 100) - (first * l));
                                    if(!diff1.IsX6()) { continue; }
                                    Console.WriteLine($"{first} {second} {sum}");
                                }
                            }
                        }
                    }
                }
            }
        }
        internal static void SolveQ4() // 28081 1734 48692454
        {
            foreach (var first in Enumerator.NumberInNdigits(5).Where(IntExtensions.IsOdd))
            {
                foreach (var j in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    if (!(first * j).IsXXX567()) { continue; }
                    foreach (var l in Enumerator.FromOneToNine())
                    {
                        if (!(first * l).IsX123XX()) { continue; }
                        foreach (var i in Enumerator.FromOneToNine())
                        {
                            if (!(first * i).IsXXX8X()) { continue; }
                            foreach (var k in Enumerator.FromOneToNine())
                            {
                                if (!(first * k).IsX4XXX()) { continue; }
                                var second = (int)(new[] { i, j, k, l }).ToDecade();
                                var ans = first * second;
                                if (!ans.IsXXX9XXXX()) { continue; }
                                Console.WriteLine($"{first} {second} {ans}");
                            }
                        }
                    }
                }
            }
        }
        internal static void SolveQ5() // 919622 59115 54363454530
        {
            foreach (var first in Enumerator.NumberInNdigits(6))
            {
                foreach (var k in Enumerator.FromOneToNine())
                {
                    if(!(first * k).IsXX9X2X()) { continue; }
                    foreach(var i in Enumerator.FromOneToNine())
                    {
                        var lineI = first * i;
                        if (!lineI.IsXXXXX1X()) { continue; }
                        foreach (var j in Enumerator.FromOneToNine())
                        {
                            if (!(first * j).IsXXXX5XX()) { continue; }
                            foreach (var l in Enumerator.FromOneToNine())
                            {
                                if (!(first * l).IsXXX6XX()) { continue; }
                                foreach (var m in Enumerator.FromOneToNine())
                                {
                                    var lineM = first * m;
                                    if (!lineM.IsXXX8XXX()) { continue; }
                                    var second = (new int[] { i, j, k, l, m, }).ToDecade();
                                    var ans = first * second;
                                    var diffI = ((int)(ans / 10000) - lineI);
                                    if (!diffI.IsXXXX3X()) { continue; }
                                    var diffIJ = ((int)(ans / 1000) - (first * (int)(new int[] { i, j }).ToDecade()));
                                    if (!diffIJ.IsXXX7XX()) { continue; }
                                    var diffIJK = ((int)(ans / 100) - (first * (int)(new int[] { i, j, k }).ToDecade()));
                                    if (!diffIJK.IsXXXX4X()) { continue; }
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
