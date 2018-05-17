using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201804
{
    static class Q20180415_104
    {
        internal static void SolveQ1() // 14 41 574
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                var first = (int)(new[] { i, 4 }).ToDecade();
                foreach (var k in Enumerator.FromOneToNine())
                {
                    if (!(first * k).Is1X()) { continue; }
                    foreach (var j in Enumerator.FromOneToNine())
                    {
                        if (!(first * j).Is2digits()) { continue; }
                        var second = (int)(new[] { j, k }).ToDecade();
                        var ans = first * second;
                        if (!ans.Is5XX()) { continue; }
                        Console.WriteLine($"{first} {second} {ans}");
                    }
                }
            }
        }
        internal static void SolveQ2() // 54 84 4536
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                var first = (int)(new[] { i, 4 }).ToDecade();
                foreach (var k in Enumerator.FromOneToNine())
                {
                    if (!(first * k).IsX1X()) { continue; }
                    foreach (var j in Enumerator.FromOneToNine())
                    {
                        if (!(first * j).Is3digits()) { continue; }
                        var second = (int)(new[] { j, k }).ToDecade();
                        var ans = first * second;
                        if (!ans.IsX5XX()) { continue; }
                        Console.WriteLine($"{first} {second} {ans}");
                    }
                }
            }
        }
        internal static void SolveQ3() // 1259 674 848566
        {
            foreach (var first in Enumerator.NumberInNdigits(4))
            {
                foreach (var i in Enumerator.FromOneToNine())
                {
                    if (!((first * i)).IsXXX4()) { continue; }
                    foreach (var j in Enumerator.FromOneToNine())
                    {
                        if (!((first * j)).IsXX1X()) { continue; }
                        foreach (var k in Enumerator.FromOneToNine())
                        {
                            if (!((first * k)).IsXX3X()) { continue; }
                            var second = (int)(new[] { i, j, k }).ToDecade();
                            var ans = first * second;
                            if(!ans.IsXXXX6X()) { continue; }
                            var diffI = (ans / 100) - (first * i);
                            if(!diffI.Is9XX()) { continue; }
                            Console.WriteLine($"{first} {second} {ans}");
                        }
                    }
                }
            }
        }
        internal static void SolveQ4() // 97 18 1746
        {
            foreach (var nums in Enumerator.Permutations(Enumerator.FromZeroToNine(), 6))
            {
                var d = nums.ElementAt(0);
                var e = nums.ElementAt(1);
                var n = nums.ElementAt(2);
                var a = nums.ElementAt(3);
                var ren = nums.ElementAt(4);
                var sho = nums.ElementAt(5);
                var first = (int)(new[] { d, e }).ToDecade();
                if (!(first * n).Is2digits()) { continue; }
                if (!(first * a).Is3digits()) { continue; }
                var second = (int)(new[] { n, a }).ToDecade();
                var seven = (int)(new[] { 7, ren, sho }).ToDecade();
                var ans = first * second;
                if (!ans.Is4digits()) { continue; }
                if ((ans % 1000) != seven) { continue; }
                Console.WriteLine($"{first} {second} {ans}");
            }
        }
        internal static void SolveQ5() // 187298 56956 10667744888
        {
            foreach (var first in Enumerator.NumberInNdigits(6))
            {
                foreach (var i in Enumerator.FromOneToNine())
                {
                    if (!(first * i).IsXXXX90()) { continue; }
                    foreach (var k in Enumerator.FromOneToNine())
                    {
                        if (!(first * k).IsXXX56XX()) { continue; }
                        foreach (var m in Enumerator.FromOneToNine())
                        {
                            if (!(first * m).IsX12XXXX()) { continue; }
                            foreach (var j in Enumerator.FromOneToNine())
                            {
                                if (!(first * j).IsXXXX7X8()) { continue; }
                                var a = first * j;
                                foreach (var l in Enumerator.FromOneToNine())
                                {
                                    if (!(first * l).IsX3X4XX()) { continue; }
                                    var second = (new int[] { i, j, k, l, m, }).ToDecade();
                                    var ans = first * second;
                                    if (!ans.Is11digits()) { continue; }
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
