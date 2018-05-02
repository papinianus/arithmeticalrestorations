using System.Collections.Generic;
using static System.Linq.Enumerable;
using static System.Math;

namespace ExtensionMethods
{
    public static class Enumerator
    {
        #region enumeration of single digit
        public static IEnumerable<int> FromOneToNine() => Range(1, 9);
        public static IEnumerable<int> FromZeroToNine() => Range(0, 10);
        #endregion enumerator of single digit
        #region enumeration of specified digits
        public static IEnumerable<int> NumberInNdigits(int n) => Range((int)Pow(10, n - 1), (int)Pow(10, n) - (int)Pow(10, n - 1));
        #endregion enumeration of specified digits
        public static IEnumerable<IEnumerable<T>> Permutations<T>(IEnumerable<T> list, int length)
        {//https://stackoverflow.com/questions/756055/listing-all-permutations-of-a-string-integer
            if (length == 1) return list.Select(t => new T[] { t });

            return Permutations(list, length - 1).SelectMany(t => list.Where(e => !t.Contains(e)), (t1, t2) => t1.Concat(new T[] { t2 }));
        }
    }
}
