using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201805
{
    static class Q20180520_109
    {
        internal static void SolveQ1() // 25 8 200
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                var first = (int)(new[] { i, 5 }).ToDecade();
                foreach (var j in Enumerator.FromOneToNine())
                {
                    var second = j;
                    var sum = first * second;
                    if (!sum.Is20X()) { continue; }
                    Console.WriteLine($"{first} {second} {sum}");
                }
            }
        }
        internal static void SolveQ2() // 58 19 1102
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                var first = (int)(new[] { 5, i }).ToDecade();
                foreach (var k in Enumerator.FromOneToNine())
                {
                    if (!(first * k).IsX2X()) { continue; }
                    foreach (var j in Enumerator.FromOneToNine())
                    {
                        if (!(first * j).Is2digits()) { continue; }
                        var second = (int)(new[] { j, k }).ToDecade();
                        var sum = first * second;
                        if (!sum.IsXX0X()) { continue; }
                        Console.WriteLine($"{first} {second} {sum}");
                    }
                }
            }
        }
        internal static void SolveQ3() // 2653 143 379379
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                foreach (var j in Enumerator.FromZeroToNine())
                {
                    foreach (var k in Enumerator.FromZeroToNine().Where(IntExtensions.IsOdd))
                    {
                        var first = (int)(new[] { i, 6, j, k }).ToDecade();
                        if(!(first * 4).IsXXX1X()) { continue; }
                        foreach (var l in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                        {
                            if (!((first * l)).IsXXX3()) { continue; }
                            foreach (var m in Enumerator.FromOneToNine())
                            {
                                if (!((first * m)).IsX9XX()) { continue; }
                                var second = (int)(new[] { l, 4, m }).ToDecade();
                                var sum = first * second;
                                Console.WriteLine($"{first} {second} {sum}");
                            }
                        }
                    }
                }
            }
        }
        internal static void SolveQ4() // 1973 528 1041744
        {
            foreach (var nums in Enumerator.Permutations(Enumerator.FromZeroToNine(), 9))
            {
                var fuji = nums.ElementAt(0);
                var i = nums.ElementAt(1);
                var dan = nums.ElementAt(2);
                var sai = nums.ElementAt(3);
                var nen = nums.ElementAt(4);
                var sho = nums.ElementAt(5);
                var year = nums.ElementAt(6);
                var ka = nums.ElementAt(7);
                var getu = nums.ElementAt(8);
                var first = (int)(new[] { fuji, i, 7, dan }).ToDecade();
                var line1 = first * sho;
                if (!line1.Is15XXX()) { continue; }
                if (line1.Find3rdDigit() != year) { continue; }
                var line2 = first * nen;
                if (!line2.IsX9XX()) { continue; }
                if (line2.FindNNthDigitFromRight() != (int)(new[] { ka, getu }).ToDecade()) { continue; }
                if (!(first * sai).Is4digits()) { continue; }
                var second = (int)(new[] { sai, nen, sho }).ToDecade();
                var sum = first * second;
                if (!sum.Is7digits()) { continue; }
                Console.WriteLine($"{first} {second} {sum}");
            }

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
        internal static void SolveQ5() // 324562 5688 1846108656
        {
            foreach (var first in Enumerator.NumberInNdigits(6))
            {
                foreach (var j in Enumerator.FromOneToNine())
                {
                    if(!(first * j).IsXX4XX7X()) { continue; }
                    foreach(var i in Enumerator.FromOneToNine())
                    {
                        var lineI = first * i;
                        if (!lineI.IsXXX2XXX()) { continue; }
                        foreach (var k in Enumerator.FromOneToNine())
                        {
                            foreach (var l in Enumerator.FromOneToNine())
                            {
                                var second = (new int[] { i, j, k, l, }).ToDecade();
                                var ans = first * second;
                                if (!ans.IsXXXX10XXXX()) { continue; }
                                var diffI = ((int)(ans / 1000) - lineI);
                                if (!diffI.IsXX3X98()) { continue; }
                                var diffIJ = ((int)(ans / 100) - (first * (int)(new int[] { i, j }).ToDecade()));
                                if (!diffIJ.IsXX56XX()) { continue; }
                                //var diffIJK = ((int)(ans / 100) - (first * (int)(new int[] { i, j, k }).ToDecade()));
                                //if (!diffIJK.IsXXXX4X()) { continue; }
                                Console.WriteLine($"{first} {second} {ans}");
                            }
                        }
                    }
                }
            }
        }
    }
}
