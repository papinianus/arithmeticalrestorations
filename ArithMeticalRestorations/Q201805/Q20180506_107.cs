using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201805
{
    static class Q20180506_107
    {
        internal static void SolveQ1()
        {
            foreach(var i in Enumerator.FromOneToNine())
            {

                var first = 7;
                var second = i;
                var sum = first * second;
                if (sum / 10 == 5) { Console.WriteLine($"{first} {second} {sum}"); }

            }
        }
        internal static void SolveQ2()
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                var first = (int)(new[] { 5, i }).ToDecade();
                foreach (var j in Enumerator.FromOneToNine())
                {
                    if(!((first * j)).IsX7()) { continue; }
                    foreach (var k in Enumerator.FromOneToNine())
                    {
                        if (!((first * k)).Is2digits()) { continue; }
                        var second = (int)(new[] { j, k }).ToDecade();
                        if (!((first * second)).Is3digits()) { continue; }
                        Console.WriteLine($"5{i} {j}{k} {first * second}");
                    }
                }
            }
        }
        internal static void SolveQ3()
        {//3193 343 1095199
            foreach (var i in Enumerator.FromOneToNine())
            {
                foreach (var j in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    foreach (var k in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                    {
                        var first = (new[] { i, 1, j, k}).ToDecade();
                        if (!((int)(first * 3)).IsXXX9()) { continue; }
                        foreach (var l in Enumerator.FromOneToNine())
                        {
                            if (!((int)(first * l)).IsXXX7X()) { continue; }
                            foreach (var m in Enumerator.FromOneToNine())
                            {
                                if (!((int)(first * m)).IsX5XX()) { continue; }
                                var second = (new[] { 3, l, m }).ToDecade();
                                if (!((int)(first * second)).Is7digits()) { continue; }
                                Console.WriteLine($"{first} {second} {first * second}");
                            }
                        }
                    }
                }
            }
        }
        internal static void SolveQ4()
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                foreach (var j in Enumerator.FromZeroToNine())
                {
                    if (i == j) { continue; }
                    foreach (var k in Enumerator.FromZeroToNine())
                    {
                        if (i == k || j == k) { continue; }
                        var first = (int)(new[] { i, j, 6, k }).ToDecade();
                        foreach (var m in Enumerator.FromOneToNine())
                        {
                            if (i == m || j == m || k == m) { continue; }
                            var line2 = first * m;
                            if(!line2.IsXX4XX()) { continue; }
                            var o = line2 % 10;
                            var p = (line2 / 10) % 10;
                            if (i == o || j == o || k == o || m == o) { continue; }
                            if (i == p || j == p || k == p || m == p || o == p) { continue; }
                            foreach (var l in Enumerator.FromOneToNine())
                            {
                                if (i == l || j == l || k == l || m == l || o == l || p == l) { continue; }
                                if(!(first * l).Is4digits()) { continue; }
                                foreach (var n in Enumerator.FromOneToNine())
                                {
                                    if (i == n || j == n || k == n || m == n || o == n || p == n || l == n) { continue; }
                                    if (!(first * n).Is4digits()) { continue; }
                                    var second = (int)(new[] { l, m, n }).ToDecade();
                                    var ans = first * second;
                                    if(!ans.Is7digits()) { continue; }
                                    Console.WriteLine($"{first} {second} {ans}");
                                }
                            }
                        }
                    }
                }
            }
        }
        internal static void SolveQ5()
        {
            foreach (var first in Enumerator.NumberInNdigits(5))
            {
                foreach (var m in Enumerator.FromOneToNine())
                {
                    if(!(first * m).Is123XXX()) { continue; }
                    foreach(var k in Enumerator.FromOneToNine())
                    {
                        if (!(first * k).IsXX567X()) { continue; }
                        foreach (var i in Enumerator.FromOneToNine())
                        {
                            if (!(first * i).IsXXXX9X()) { continue; }
                            foreach (var j in Enumerator.FromOneToNine())
                            {
                                if (!(first * j).IsXXX8XX()) { continue; }
                                foreach (var l in Enumerator.FromOneToNine())
                                {
                                    if (!(first * l).IsX4XXXX()) { continue; }
                                    var second = (new int[] { i, j, k, l, m }).ToDecade();
                                    var ans = first * second;
                                    if(!ans.IsXXXX0XXXXX()) { continue; }
                                    Console.WriteLine($"{first} {second} {first * second}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
