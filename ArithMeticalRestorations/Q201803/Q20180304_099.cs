using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201803
{
    static class Q20180304_099
    {
        internal static void SolveQ1() // 3 8 24
        {
            var first = 3;
            foreach(var second in Enumerator.FromOneToNine())
            {
                var ans = first * second;
                if (!ans.IsX4()) { continue; }
                Console.WriteLine($"{first} {second} {ans}");
            }
        }
        internal static void SolveQ2() // 32 32 1024
        {
            foreach (var first in Enumerator.NumberInNdigits(2))
            {
                if (!(first * 3).Is2digits()) { continue; }
                foreach (var i in Enumerator.FromOneToNine())
                {
                    if (!(first * i).IsX4()) { continue; }
                    var second = (int)(new[] { 3, i, }).ToDecade();
                    var ans = first * second;
                    Console.WriteLine($"{first} {second} {ans}");
                }
            }
        }
        internal static void SolveQ3() // 855 76 64980
        {
            foreach (var first in Enumerator.NumberInNdigits(3))
            {
                if (!(first * 6).IsX13X()) { continue; }
                foreach (var i in Enumerator.FromOneToNine())
                {
                    if (!(first * i).IsX9XX()) { continue; }
                    var second = (int)(new[] { i, 6, }).ToDecade();
                    var ans = first * second;
                    if (!ans.IsX4XXX()) { continue; }
                    Console.WriteLine($"{first} {second} {ans}");
                }
            }
        }
        internal static void SolveQ4() // 74 83 6142
        {
            foreach (var nums in Enumerator.Permutations(Enumerator.FromZeroToNine(), 9))
            {
                var mu = nums.ElementAt(0);
                var si = nums.ElementAt(1);
                var ku = nums.ElementAt(2);
                var i = nums.ElementAt(3);
                var sa = nums.ElementAt(4);
                var a = nums.ElementAt(5);
                var ra = nums.ElementAt(6);
                var ta = nums.ElementAt(7);
                var no = nums.ElementAt(8);
                var first = (int)(new[] { mu, si }).ToDecade();
                var sasasa = (int)(new[] { sa, sa, sa }).ToDecade();
                if ((first * i) != sasasa) { continue; }
                var arasa = (int)(new[] { a, ra, sa }).ToDecade();
                if ((first * ku) != arasa) { continue; }
                var second = (int)(new[] { ku, i }).ToDecade();
                var ans = first * second;
                var tanosisa = (int)(new[] { ta, no, si, sa, }).ToDecade();
                if (ans != tanosisa) { continue; }
                Console.WriteLine($"{first} {second} {ans}");
            }
        }
        internal static void SolveQ5() // 128184 57938 7426724592
        {
            foreach (var first in Enumerator.NumberInNdigits(6))
            {
                foreach (var m in Enumerator.FromOneToNine())
                {
                    if(!(first * m).Is1X2XXXX()) { continue; }
                    foreach(var l in Enumerator.FromOneToNine())
                    {
                        if (!(first * l).Is3X4XXX()) { continue; }
                        foreach (var i in Enumerator.FromOneToNine())
                        {
                            if (!(first * i).IsXXX9X0()) { continue; }
                            foreach (var j in Enumerator.FromOneToNine())
                            {
                                if (!(first * j).IsXX7X8X()) { continue; }
                                foreach (var k in Enumerator.FromOneToNine())
                                {
                                    if (!(first * k).IsXX5X6XX()) { continue; }
                                    var second = (new int[] { i, j, k, l, m, }).ToDecade();
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
