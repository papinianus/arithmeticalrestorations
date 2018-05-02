using System.Collections.Generic;
using static System.Linq.Enumerable;
using static System.Math;

namespace ExtensionMethods
{
    public static class Enumerator
    {
        #region enumeration of single digit
        public static IEnumerable<int> FromOneToNine() => Range(1, 9);
        public static IEnumerable<int> FromZeroToNine() => Range(0, 9);
        #endregion enumerator of single digit
        #region enumeration of specified digits
        public static IEnumerable<int> NumberInNdigits(int n) => Range((int)Pow(10, n - 1), (int)Pow(10, n) - (int)Pow(10, n - 1));
        #endregion enumeration of specified digits
    }
}
