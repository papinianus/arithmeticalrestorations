using static System.Math;

namespace ExtensionMethods
{
    public static class LongExtensions //9,223,372,036,854,775,807
    {
        public static bool IsNdigits(this long i, int n = 1) => i.ToString().Length == n;
        public static bool Is1digit(this long i)   => i <            10 && i > -1;
        public static bool Is2digits(this long i)  => i <           100 && i > 9;
        public static bool Is3digits(this long i)  => i <          1000 && i > 99;
        public static bool Is4digits(this long i)  => i <         10000 && i > 999;
        public static bool Is5digits(this long i)  => i <        100000 && i > 9999;
        public static bool Is6digits(this long i)  => i <       1000000 && i > 99999;
        public static bool Is7digits(this long i)  => i <      10000000 && i > 999999;
        public static bool Is8digits(this long i)  => i <     100000000 && i > 9999999;
        public static bool Is9digits(this long i)  => i <    1000000000 && i > 99999999;
        public static bool Is10digits(this long i) => i <   10000000000 && i > 999999999;
        public static bool Is11digits(this long i) => i <  100000000000 && i > 9999999999;
        public static bool Is12digits(this long i) => i < 1000000000000 && i > 99999999999;

        private static bool IsN(this long i, long n = 1) => i == n;
        public static bool Is1(this long i) => i.IsN(1L);
        public static bool Is2(this long i) => i.IsN(2L);
        public static bool Is3(this long i) => i.IsN(3L);
        public static bool Is4(this long i) => i.IsN(4L);
        public static bool Is5(this long i) => i.IsN(5L);
        public static bool Is6(this long i) => i.IsN(6L);
        public static bool Is7(this long i) => i.IsN(7L);
        public static bool Is8(this long i) => i.IsN(8L);
        public static bool Is9(this long i) => i.IsN(9L);
        public static bool Is0(this long i) => i.IsN(0L);

        public static bool IsEven(this long i) => i % 2 == 0;
        public static bool IsOdd(this long i) => !i.IsEven();
        public static bool IsMultipleOf(this long i, int n) => i % n == 0;
        public static bool IsMultipleOfFive(this long i) => i.IsMultipleOf(5);

        public static long FindNthDigitFromRight(this long i, int n = 1) => (i / (int)Pow(10, n - 1)) % 10;
        public static long Find1stDigit(this long i) => i.FindNthDigitFromRight(1);
        public static long Find2ndDigit(this long i) => i.FindNthDigitFromRight(2);
        public static long Find3rdDigit(this long i) => i.FindNthDigitFromRight(3);
        public static long Find4thDigit(this long i) => i.FindNthDigitFromRight(4);
        public static long Find5thDigit(this long i) => i.FindNthDigitFromRight(5);
        public static long Find_X(this long i) => i.FindNthDigitFromRight(1);
        public static long Find_X1(this long i) => i.FindNthDigitFromRight(2);
        public static long Find_X21(this long i) => i.FindNthDigitFromRight(3);
        public static long Find_X321(this long i) => i.FindNthDigitFromRight(4);
        public static long Find_X4321(this long i) => i.FindNthDigitFromRight(5);

        public static long FindNNthDigitFromRight(this long i, int n = 1) => (i / (int)Pow(10, n - 1)) % 100;

        #region 10digits
        public static bool IsXXXXX0XXXX(this long i)
        {
            if (!i.Is10digits()) return false;
            return i.FindNthDigitFromRight(5) == 0L;
        }
        public static bool IsXXXX0XXXXX(this long i)
        {
            if (!i.Is10digits()) return false;
            return i.FindNthDigitFromRight(6) == 0L;
        }
        public static bool IsXXXX012XXX(this long i)
        {
            if (!i.Is10digits()) return false;
            return ((i / 1000L) % 100).IsN(12L);
        }
        public static bool IsXXXX10XXXX(this long i)
        {
            if (!i.Is10digits()) return false;
            return i.FindNNthDigitFromRight(5) == 10L;
        }
        public static bool IsXXXX32XXXX(this long i)
        {
            if (!i.Is10digits()) return false;
            return i.FindNNthDigitFromRight(5) == 32L;
        }
        #endregion 10digits
        #region 11digits
        public static bool IsXXXX9XXXXXX(this long i)
        {
            if (!i.Is11digits()) return false;
            return i.FindNthDigitFromRight(7) == 9L;
        }
        #endregion 11digits
    }
}
