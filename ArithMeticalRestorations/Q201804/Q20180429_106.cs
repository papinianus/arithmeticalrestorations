using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201804
{
    static class Q20180429_106
    {
        internal static void SolveQ1()
        {
            foreach(var i in Enumerator.FromOneToNine())
            {
                foreach (var j in Enumerator.FromOneToNine())
                {
                    var sum = (new[] { i, 4 }).ToDecade() * j;
                    if (sum / 10 == 29) { Console.WriteLine($"{i}4 {j} {sum}"); }
                }
            }
        }
        internal static void SolveQ2()
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                var first = (new[] { 4, i }).ToDecade();
                foreach (var j in Enumerator.FromOneToNine())
                {
                    if(!((int)(first * j)).IsXX2()) { continue; }
                    foreach (var k in Enumerator.FromOneToNine())
                    {
                        if (!((int)(first * k)).IsX9()) { continue; }
                        var second = (new[] { k, j }).ToDecade();
                        if (!((int)(first * second)).Is3digits()) { continue; }
                        Console.WriteLine($"4{i} {k}{j} {first * second}");
                    }
                }
            }
        }
        internal static void SolveQ3()
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                foreach (var j in Enumerator.FromOneToNine())
                {
                    foreach (var k in Enumerator.FromOneToNine())
                    {
                        var first = (new[] { 1, i, j, k }).ToDecade();
                        if (!((int)(first * 2)).IsX3XX()) { continue; }
                        foreach (var l in Enumerator.FromOneToNine())
                        {
                            if (!((int)(first * l)).IsXX5X()) { continue; }
                            foreach (var m in Enumerator.FromOneToNine())
                            {
                                if (!((int)(first * m)).IsX4XXX()) { continue; }
                                var second = (new[] { l, m, 2 }).ToDecade();
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
                        Console.WriteLine($"{first} {second} {first * second}");
                    }
                }
            }
        }
        internal static void SolveQ5()
        {
            foreach (var first in Enumerator.NumberInNdigits(7))
            {
                foreach (var i in Enumerator.FromOneToNine())
                {
                    if(!(first * i).Is16XXXXX()) { continue; }
                    foreach(var n in Enumerator.FromOneToNine())
                    {
                        if (!(first * n).IsXXXXX50()) { continue; }
                        foreach (var j in Enumerator.FromOneToNine())
                        {
                            if (!(first * j).IsXX2X7XXX()) { continue; }
                            foreach (var k in Enumerator.FromOneToNine())
                            {
                                if (!(first * k).IsXXX3X8XX()) { continue; }
                                foreach (var l in Enumerator.FromOneToNine())
                                {
                                    if (!(first * l).IsXXX4X9X()) { continue; }
                                    var second = (new int[] { n, 0, l, k, j, i }).ToDecade();
                                    Console.WriteLine($"{first} {second} {first * second}");
                                    //foreach (var m in Enumerator.FromOneToNine())
                                    //{
                                    //    var second = (new int[] { n, m, l, k, j, i }).ToDecade();
                                    //    if (!(first * second).Is12digits()) { continue; }
                                    //    Console.WriteLine($"{first} {second} {first * second}");
                                    //}
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
