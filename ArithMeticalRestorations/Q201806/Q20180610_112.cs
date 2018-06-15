using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Q201806
{
    static class Q20180610_112
    {
        internal static void SolveQ1() // 61 51 3111
        {
            foreach (var i in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
            {
                var first = (int)(new[] { 6, i, }).ToDecade();
                foreach (var k in Enumerator.FromOneToNine().Where(IntExtensions.IsOdd))
                {
                    if (!(first * k).IsX1()) { continue; }
                    foreach (var j in Enumerator.FromOneToNine())
                    {
                        if (!(first * j).IsX0X()) { continue; }
                        var second = (int)(new[] { j, k, }).ToDecade();
                        var ans = first * second;
                        Console.WriteLine($"{first} {second} {ans}");
                    }
                }
            }
        }
        internal static void SolveQ2() // 22 53 1166
        {
            foreach (var first in Enumerator.NumberInNdigits(2))
            {
                foreach (var i in Enumerator.FromOneToNine())
                {
                    if (!(first * i).IsX10()) { continue; }
                    foreach (var j in Enumerator.FromOneToNine())
                    {
                        if (!(first * j).IsX6()) { continue; }
                        var second = (int)(new[] { i, j, }).ToDecade();
                        var ans = first * second;
                        //if (!ans.Is3digits()) { continue; }
                        Console.WriteLine($"{first} {second} {ans}");
                    }
                }
            }
        }
        internal static void SolveQ3() // 393 487 191391
        {
            foreach (var first in Enumerator.NumberInNdigits(3))
            {
                foreach (var k in Enumerator.FromOneToNine())
                {
                    if (!(first * k).IsXX51()) { continue; }
                    foreach (var i in Enumerator.FromOneToNine())
                    {
                        var lineI = first * i;
                        if (!lineI.IsXXX2()) { continue; }
                        foreach (var j in Enumerator.FromOneToNine())
                        {
                            if (!(first * j).IsXX4X()) { continue; }
                            var second = (int)(new[] { i, j, k, }).ToDecade();
                            var ans = first * second;
                            var diffI = ans / 100 - lineI;
                            if (!diffI.Is3XX()) { continue; }
                            Console.WriteLine($"{first} {second} {ans}");
                        }
                    }
                }
            }
        }
        internal static void SolveQ4() // 2569 683 1754627
        {
            foreach (var nums in Enumerator.Permutations(Enumerator.FromZeroToNine(), 10))
            {
                var se= nums.ElementAt(0);
                if(se == 0) { continue; }
                var ri = nums.ElementAt(1);
                var i = nums.ElementAt(2);
                var gu = nums.ElementAt(3);
                var si = nums.ElementAt(4);
                var ai = nums.ElementAt(5);
                var zen = nums.ElementAt(6);
                var sho = nums.ElementAt(7);
                var nen = nums.ElementAt(8);
                var buri = nums.ElementAt(9);
                var first = (int)(new[] { se, ri, i, gu }).ToDecade();
                var _4nenburi = (int)(new[] { 4, nen, buri }).ToDecade();
                if (!(first * 6).Is5digits()) { continue; }
                if ((first * 6) % 1000 != _4nenburi ) { continue; }
                var _zensho = (int)(new[] { zen, sho }).ToDecade();
                if (!(first * ai).Is4digits()) { continue; }
                if ((first * ai) % 100 != _zensho) { continue; }
                //if (!(first * si).Is5digits()) { continue; }
                var second = (int)(new[] { 6, si, ai }).ToDecade();
                var ans = first * second;
                Console.WriteLine($"{first} {second} {ans}");
            }
        }
        internal static void SolveQ5() // 13563990 97691 1325079747090
        {
            foreach (var first in Enumerator.NumberInNdigits(8))
            {
                foreach (var i in Enumerator.FromOneToNine())
                {
                    if (!(first * i).IsXXXXX5XX0()) { continue; }
                    foreach (var j in Enumerator.FromOneToNine())
                    {
                        if (!(first * j).IsXXX4X9XX()) { continue; }
                        foreach (var k in Enumerator.FromOneToNine())
                        {
                            if (!(first * k).IsXX38XXXX()) { continue; }
                            foreach (var l in Enumerator.FromOneToNine())
                            {
                                if (!(first * l).IsXX2X7XXXX()) { continue; }
                                foreach (var m in Enumerator.FromOneToNine())
                                {
                                    if (!(first * m).Is1XX6XXXX()) { continue; }

                                    var second = (new int[] { i, j, k, l, m, }).ToDecade();
                                    var ans = first * second;
                                    //if (!ans.IsXXXX98XXXXX()) { continue; }
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
