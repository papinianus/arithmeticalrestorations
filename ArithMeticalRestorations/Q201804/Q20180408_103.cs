using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201804
{
    static class Q20180408_103
    {
        internal static void SolveQ1()
        {
            foreach(var i in Enumerator.FromOneToNine())
            {
                var first = 4;
                var second = i;
                var sum = first * second;
                if (!sum.Is2digits()) { continue; }
                if (sum % 10 == 8) { Console.WriteLine($"{first} {second} {sum}"); }
            }
        }
        internal static void SolveQ2()
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                var first = (int)(new[] { i, 4 }).ToDecade();
                foreach (var k in Enumerator.FromOneToNine())
                {
                    if(!((first * k)).Is8X()) { continue; }
                    foreach (var j in Enumerator.FromOneToNine())
                    {
                        if (!((first * j)).Is2digits()) { continue; }
                        var second = (int)(new[] { j, k }).ToDecade();
                        if (!((first * second)).Is4digits()) { continue; }
                        Console.WriteLine($"{i}4 {j}{k} {first * second}");
                    }
                }
            }
        }
        internal static void SolveQ3()
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                foreach (var j in Enumerator.FromZeroToNine())
                {
                    foreach (var k in Enumerator.FromZeroToNine().Where(IntExtensions.IsOdd))
                    {
                        var first = (new[] { i, 6, j, k }).ToDecade();
                        if(first == 1629)
                        {
                            var a = 0;
                        }
                        if (!((int)(first * 4)).IsXX1X()) { continue; }
                        foreach (var l in Enumerator.FromZeroToNine().Where(IntExtensions.IsOdd))
                        {
                            if (!((int)(first * l)).IsXXXX3()) { continue; }
                            foreach (var m in Enumerator.FromZeroToNine())
                            {
                                if (!((int)(first * m)).Is9XXX()) { continue; }
                                var second = (new[] { l, 4, m }).ToDecade();
                                if (!((int)(first * second)).Is7digits()) { continue; }
                                Console.WriteLine($"{first} {second} {first * second} {first * 4}");
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
