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
            foreach (var nums in Enumerator.Permutations(Enumerator.FromZeroToNine(), 6))
            {
                var bi = nums.ElementAt(0);
                var bu = nums.ElementAt(1);
                var n  = nums.ElementAt(2);
                var se = nums.ElementAt(3);
                var ki = nums.ElementAt(4);
                var i  = nums.ElementAt(5);
                var first = (int)(new[] { bi, bu, n }).ToDecade();
                if (!(first * se).Is4digits()) { continue; }
                if (!(first * ki).Is4digits()) { continue; }
                if (!(first * bu).Is4digits()) { continue; }
                if (!(first * n).Is4digits()) { continue; }
                var second = (int)(new[] { se, ki, bu, n }).ToDecade();
                var feelsgood = (int)(new[] { i, i, ki, bu, n }).ToDecade();
                var ans = first * second;
                if((ans % 100000) != feelsgood) { continue; }
                Console.WriteLine($"{first} {second} {ans}");
            }
        }
        internal static void SolveQ5()
        {
            foreach (var first in Enumerator.NumberInNdigits(7))
            {
                foreach (var j in Enumerator.FromOneToNine())
                {
                    if(!(first * j).IsXX567XX()) { continue; }
                    foreach(var i in Enumerator.FromOneToNine())
                    {
                        var line1 = first * i;
                        if (!line1.IsXXXX1X2()) { continue; }
                        foreach (var k in Enumerator.FromOneToNine())
                        {
                            if (!(first * k).Is8XXX9XX()) { continue; }
                            var second = (new int[] { i, 0, j, k }).ToDecade();
                            var ans = first * second;
                            if (!ans.IsXXXXX0XXXX()) { continue; }
                            var headOfAns = ans / 1000;
                            var diff = headOfAns - line1;
                            if(!((int)diff).IsXX3X4()) { continue; }
                            Console.WriteLine($"{first} {second} {first * second}");
                        }
                    }
                }
            }
        }
    }
}
