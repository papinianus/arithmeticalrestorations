using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    public static class IEnumerableIntExtensions
    {
        public static long ToDecade(this IEnumerable<int> nums) => nums.Aggregate((n, next) => n * 10 + next);
    }
}
