using System.Collections.Generic;
using static System.Linq.Enumerable;

namespace ExtensionMethods
{
    public static class Enumerator
    {
        #region enumeration of single digit
        public static IEnumerable<int> FromOneToNine() => Range(1, 9);
        public static IEnumerable<int> FromZeroToNine() => Range(0, 9);
        #endregion enumerator
    }
}
