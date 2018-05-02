using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201804
{
    static class Q20180401_102
    {
        internal static void SolveQ1()
        {
            foreach(var i in Enumerator.FromOneToNine())
            {
                foreach (var j in Enumerator.FromOneToNine())
                {
                    var first = (int)(new[] { 4, i }).ToDecade();
                    var second = j;
                    var sum = first * second;
                    if (sum % 100 == 1) { Console.WriteLine($"{first} {second} {sum}"); }
                }
            }
        }
        internal static void SolveQ2()
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                var first = (int)(new[] { 4, i }).ToDecade();
                foreach (var j in Enumerator.FromOneToNine())
                {
                    if(!((first * j)).IsX0X()) { continue; }
                    foreach (var k in Enumerator.FromOneToNine())
                    {
                        if (!((first * k)).Is3digits()) { continue; }
                        var second = (int)(new[] { k, j }).ToDecade();
                        if (!((first * second)).IsXX1X()) { continue; }
                        Console.WriteLine($"4{i} {k}{j} {first * second}");
                    }
                }
            }
        }
        internal static void SolveQ3()
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                foreach (var j in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    foreach (var l in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                    {
                        var first = (new[] { i, 6, j}).ToDecade();
                        if (!((int)(first * l)).IsXX9()) { continue; }
                        foreach (var m in Enumerator.FromOneToNine())
                        {
                            if (!((int)(first * m)).Is4XXX()) { continue; }
                            foreach (var k in Enumerator.FromOneToNine())
                            {
                                if (!((int)(first * k)).IsXX1X()) { continue; }
                                var second = (new[] { k, l, m }).ToDecade();
                                if (!((int)(first * second)).IsXXXXX3()) { continue; }
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
                foreach (var j in Enumerator.FromOneToNine())
                {
                    if (i == j) { continue; }
                    foreach (var k in Enumerator.FromOneToNine())
                    {
                        if (i == k || j == k) { continue; }
                        var first = (new[] { i, j, k }).ToDecade();
                        if (!((int)(first * k)).Is4digits()) { continue; }
                        if (!((int)(first * j)).Is3digits()) { continue; }
                        var second = (new[] { j, k, j, k }).ToDecade();
                        var ans = (int)(first * second);
                        if (!ans.Is7digits()) { continue; }
                        var mochi = (int)(new[] { j, k }).ToDecade();
                        if (ans % 100 != mochi) { continue; }
//                        Console.WriteLine($"{first} {second} {first * second}");
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
