﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201803
{
    static class Q20180325_101
    {
        internal static void SolveQ1() //25 13 325
        {
            foreach (var first in Enumerator.NumberInNdigits(2))
            {
                foreach (var i in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    if(first * i != 25) { continue; }
                    if(!(first * 3).Is2digits()) { continue; }
                    var second = (int)(new[] { i, 3 }).ToDecade();
                    var ans = first * second;
                    if (!ans.Is3digits()) { continue; }
                    Console.WriteLine($"{first} {second} {ans}");
                }
            }
        }
        internal static void SolveQ2() // 75 13 975
        {
            foreach (var first in Enumerator.NumberInNdigits(2))
            {
                foreach (var i in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    if (!(first * i).IsX5()) { continue; }
                    if (!(first * 3).IsX2X()) { continue; }
                    var second = (int)(new[] { i, 3 }).ToDecade();
                    var ans = first * second;
                    if (!ans.Is3digits()) { continue; }
                    Console.WriteLine($"{first} {second} {ans}");
                }
            }
        }
        internal static void SolveQ3() // 913 471 430023
        {
            foreach (var first in Enumerator.NumberInNdigits(3))
            {
                foreach (var k in Enumerator.FromOneToNine())
                {
                    if (!(first * k).IsX13()) { continue; }
                    foreach (var i in Enumerator.FromOneToNine())
                    {
                        var lineI = first * i;
                        if (!lineI.IsX6XX()) { continue; }
                        foreach (var j in Enumerator.FromOneToNine())
                        {
                            if (!(first * j).IsXX9X()) { continue; }
                            var second = (int)(new[] { i, j, k, }).ToDecade();
                            var ans = first * second;
                            var diffI = (ans / 100) - lineI;
                            if (!diffI.IsX4X()) { continue; }
                            Console.WriteLine($"{first} {second} {ans}");
                        }
                    }
                }
            }
        }
        internal static void SolveQ4() // 12345312 89981 1110843519072
        {
            foreach (var first in Enumerator.NumberInNdigits(8))
            {
                foreach(var m in Enumerator.FromOneToNine())
                {
                    if(!(first * m).Is12345XXX()) { continue; }
                    foreach(var i in Enumerator.FromOneToNine())
                    {
                        if (!(first * i).IsXXXXXX9X()) { continue; }
                        foreach (var j in Enumerator.FromOneToNine())
                        {
                            if (!(first * j).IsXXXXXX8XX()) { continue; }
                            foreach (var k in Enumerator.FromOneToNine())
                            {
                                if (!(first * k).IsXXXXX7XXX()) { continue; }
                                foreach (var l in Enumerator.FromOneToNine())
                                {
                                    if (!(first * l).IsXXX6XXXX()) { continue; }
                                    var second = (new[] { i, j, k, l, m, }).ToDecade();
                                    var ans = first * second;
                                    if (!ans.IsNdigits(13)) { continue; }
                                    Console.WriteLine($"{first} {second} {ans}");
                                }
                            }
                        }
                    }
                }
            }
        }
        internal static void SolveQ5() // 634954 1037 658447298
        {
            foreach (var first in Enumerator.NumberInNdigits(6))
            {
                foreach (var k in Enumerator.FromOneToNine())
                {
                    var lineK = first * k;
                    if(!lineK.Is7digits()) { continue; }
                    if(!(lineK / 1000).hasSameDigits()) { continue; }
                    var s = lineK.Find4thDigit();
                    foreach(var i in Enumerator.FromOneToNine())
                    {
                        var lineI = first * i;
                        if (!lineI.Is6digits()) { continue; }
                        if (lineI.Find1stDigit() != s) { continue; }
                        if (lineI.Find4thDigit() != s) { continue; }
                        foreach (var j in Enumerator.FromOneToNine())
                        {
                            var lineJ = first * j;
                            if (!lineJ.Is7digits()) { continue; }
                            if (lineJ.Find4thDigit() != s) { continue; }

                            var second = (new int[] { i, 0, j, k, }).ToDecade();
                            var ans = first * second;
                            if(!ans.Is9digits()) { continue; }
                            if (ans.Find5thDigit() != s) { continue; }
                            if (ans.FindNthDigitFromRight(6) != s) { continue; }
                            Console.WriteLine($"{first} {second} {ans}");
                        }
                    }
                }
            }
        }
    }
}