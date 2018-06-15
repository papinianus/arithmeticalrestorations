using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201806
{
    static class Q20180617_113
    {
        internal static void SolveQ1() // 86 2 172
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                var first = (int)(new[] { i, 6, }).ToDecade();
                foreach (var j in Enumerator.FromOneToNine())
                {
                    var second = (int)(new[] { j, }).ToDecade();
                    var ans = first * second;
                    if(ans / 10 != 17) { continue; }
                    Console.WriteLine($"{first} {second} {ans}");
                }
            }
        }
        internal static void SolveQ2() // 13 69 897
        {
            foreach (var first in Enumerator.NumberInNdigits(2))
            {
                if (!(first * 6).Is2digits()) { continue; }
                foreach (var i in Enumerator.FromOneToNine())
                {
                    if (!(first * i).IsX1X()) { continue; }
                    var second = (int)(new[] { 6, i,}).ToDecade();
                    var ans = first * second;
                    if (!ans.IsXX7()) { continue; }
                    Console.WriteLine($"{first} {second} {ans}");
                }
            }
        }
        internal static void SolveQ3() // 683 419 286177
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                foreach (var j in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    var first = (int)(new[] { 6, i, j, }).ToDecade();
                    if (!(first * 9).IsX1XX()) { continue; }
                    //if (!(first * 4).Is4digits()) { continue; }
                    foreach (var k in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                    {
                        if (!(first * k).IsXX3()) { continue; }
                        var second = (int)(new[] { 4, k, 9, }).ToDecade();
                        var ans = first * second;
                        //if (!ans.Is6digits()) { continue; }
                        Console.WriteLine($"{first} {second} {ans}");
                    }
                }
            }
        }
        internal static void SolveQ4() // 1552263 2000389 3105129830307
        {
            foreach(var i in Enumerator.FromOneToNine())
            {
                foreach (var j in Enumerator.FromOneToNine())
                {
                    foreach (var k in Enumerator.FromOneToNine())
                    {
                        foreach (var l in Enumerator.FromOneToNine())
                        {
                            foreach (var m in Enumerator.FromOneToNine())
                            {
                                foreach (var n in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                                {
                                    var first = (int)(new[] { 1, i, j, k, l, m, n, }).ToDecade();
                                    foreach (var o in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                                    {
                                        if (!(first * o).IsXX56789()) { continue; }
                                        foreach (var p in Enumerator.FromOneToNine())
                                        {
                                            if (!(first * p).IsXX4XXXXX()) { continue; }
                                            foreach (var q in Enumerator.FromOneToNine())
                                            {
                                                if (!(first * q).IsX3XXXXXX()) { continue; }
                                                var second = (new[] { 2, 0, 0, 0, o, p, q, }).ToDecade();
                                                var ans = first * second;
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
        }
        internal static void SolveQ5() // 2469136 2729229 6738837576144
        {
            foreach (var a in Enumerator.FromOneToNine())
            {
                var sevenA = (int)(new[] { a, a, a, a, a, a, a, }).ToDecade();
                foreach (var first in Enumerator.NumberInNdigits(7))
                {
                    foreach (var o in Enumerator.FromOneToNine())
                    {
                        if(first * o / 10 != sevenA) { continue; }
                        foreach (var m in Enumerator.FromOneToNine())
                        {
                            var LineM = first * m;
                            if (!LineM.Is7digits() || (LineM % 10) != a || (LineM.Find3rdDigit()) != a) { continue; }
                            foreach (var i in Enumerator.FromOneToNine())
                            {
                                var LineI = first * i;
                                if (!LineI.Is7digits() || (LineI % 10) != a) { continue; }
                                foreach (var j in Enumerator.FromOneToNine())
                                {
                                    var LineJ = first * j;
                                    if (!LineJ.Is8digits() || (LineJ % 10) != a) { continue; }
                                    foreach (var l in Enumerator.FromOneToNine())
                                    {
                                        var LineL = first * l;
                                        if (!LineL.Is8digits() || (LineL.Find2ndDigit()) != a) { continue; }

                                        foreach (var k in Enumerator.FromOneToNine())
                                        {
                                            var LineK = first * k;
                                            if (!LineK.Is7digits() || (LineK % 10) != a) { continue; }
                                            foreach (var n in Enumerator.FromOneToNine())
                                            {
                                                var LineN = first * n;
                                                if (!LineN.Is7digits() || (LineN % 10) != a) { continue; }
                                                var second = (new int[] { i, j, k, l, m, n, o, }).ToDecade();
                                                var ans = first * second;
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
        }
    }
}
