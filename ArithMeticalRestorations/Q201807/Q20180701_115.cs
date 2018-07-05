using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201807
{
    static class Q20180701_115
    {
        internal static void SolveQ1() // 7 3 21
        {
            foreach(var second in Enumerator.FromOneToNine())
            {
                var first = 7;
                var ans = first * second;
                if (ans % 10 != 1) { continue; }
                Console.WriteLine($"{first} {second} {ans}");
            }
        }
        internal static void SolveQ2() // 74 11 814
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                var first = (int)(new[] { 7, i, }).ToDecade();
                foreach (var j in Enumerator.FromOneToNine())
                {
                    if (!(first * j).Is2digits()) { continue; }
                    foreach (var k in Enumerator.FromOneToNine())
                    {
                        if (!(first * k).Is2digits()) { continue; }
                        var second = (int)(new[] { j, k, }).ToDecade();
                        var ans = first * second;
                        if (!ans.IsX1X()) { continue; }
                        Console.WriteLine($"{first} {second} {ans}");
                    }
                }
            }
        }
        internal static void SolveQ3() // 861 199 171339
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                foreach (var j in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    var first = (int)(new[] { i, 6, j, }).ToDecade();
                    foreach (var k in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                    {
                        if (!(first * k).IsXX1()) { continue; }
                        foreach (var l in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                        {
                            if (!(first * l).IsXXX9()) { continue; }
                            foreach (var m in Enumerator.FromOneToNine())
                            {
                                if (!(first * m).IsXX4X()) { continue; }
                                var second = (int)(new[] { k, l, m, }).ToDecade();
                                var ans = first * second;
                                if (!ans.IsXXX3XX()) { continue; }
                                Console.WriteLine($"{first} {second} {ans}");

                            }
                        }
                    }
                }
            }
        }
        internal static void SolveQ4() // 2018 8683 17522294
        {
            var first = 2018;
            foreach (var nums in Enumerator.Permutations(Enumerator.FromZeroToNine(), 8))
            {
                var f = nums.ElementAt(0);
                var i = nums.ElementAt(1);
                var a = nums.ElementAt(2);
                var kes = nums.ElementAt(3);
                var sho = nums.ElementAt(4);
                var kai = nums.ElementAt(5);
                var bu = nums.ElementAt(6);
                var ri = nums.ElementAt(7);
                var lineA = first * a;
                if (!lineA.Is4digits()) { continue; }
                if (lineA / 10 % 10 != sho) { continue; }
                if (lineA / 100 % 10 != kes) { continue; }
                if (!(first * f).Is5digits()) { continue; }
                if (!(first * i).Is5digits()) { continue; }
                var second = (int)(new[] { f, i, f, a, }).ToDecade();
                var ans = first * second;
                if(!ans.Is8digits()) { continue; }
                if(ans % 10000 != (int)(new[] { 2, kai, bu, ri }).ToDecade()) { continue; }
                Console.WriteLine($"{first} {second} {ans}");
            }
        }
        internal static void SolveQ5() // 5619217 7043 39576145331
        {
            foreach (var first in Enumerator.NumberInNdigits(7).Where(IntExtensions.IsOdd))
            {
                foreach (var i in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    if (!(first * i).IsXXX3X5X9()) { continue; }
                    foreach (var j in Enumerator.FromOneToNine())
                    {
                        if (!(first * j).IsX24X68XX()) { continue; }
                        foreach (var k in Enumerator.FromOneToNine())
                        {
                            if (!(first * k).Is1XXX7XXX()) { continue; }
                            var second = (new[] { i, 0, j, k, }).ToDecade();
                            var ans = first * second;
                            Console.WriteLine($"{first} {second} {ans}");
                        }
                    }
                }
            }
        }
    }
}
