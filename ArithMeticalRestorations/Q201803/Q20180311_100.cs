using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201803
{
    static class Q20180311_100
    {
        internal static void SolveQ1() // 73 7 511
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                var first = (int)(new[] { i, 3 }).ToDecade();
                foreach (var j in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    var second = j;
                    var ans = first * second;
                    if(!ans.IsX11()) { continue; }
                    Console.WriteLine($"{first} {second} {ans}");
                }
            }
        }
        internal static void SolveQ2() // 31 36 1116
        {
            foreach (var i in Enumerator.FromOneToNine())
            {
                var first = (int)(new[] { 3, i }).ToDecade();
                foreach (var k in Enumerator.FromOneToNine())
                {
                    if(!(first * k).Is1XX()) { continue; }
                    foreach (var j in Enumerator.FromOneToNine())
                    {
                        if (!(first * j).Is2digits()) { continue; }
                        var second = (int)(new[] { j, k, }).ToDecade();
                        var ans = first * second;
                        if (!ans.IsXX1X()) { continue; }
                        Console.WriteLine($"{first} {second} {ans}");
                    }
                }
            }
        }
        internal static void SolveQ3() // 1349 79195 106834055
        {
            foreach (var first in Enumerator.NumberInNdigits(4).Where(IntExtensions.IsOdd))
            {
                foreach (var k in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    if (!(first * k).IsXXX9()) { continue; }
                    foreach (var i in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                    {
                        var lineI = first * i;
                        if (!lineI.IsXXX3()) { continue; }
                        foreach (var j in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                        {
                            if (!(first * j).IsXXXX1()) { continue; }
                            foreach (var l in Enumerator.FromOneToNine())
                            {
                                if (!(first * l).IsXXX4X()) { continue; }
                                foreach (var m in Enumerator.FromOneToNine())
                                {
                                    if (!(first * m).Is6XXX()) { continue; }
                                    var second = (int)(new[] { i, j, k, l, m, }).ToDecade();
                                    var ans = first * second;
                                    if(!ans.Is9digits()) { continue; }
                                    Console.WriteLine($"{first} {second} {ans}");
                                }
                            }
                        }
                    }
                }
            }
        }
        internal static void SolveQ4() // 
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
        internal static void SolveQ5() // 
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
