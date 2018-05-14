using static System.Math;

namespace ExtensionMethods
{
    public static class IntExtensions
    {
        public static bool IsNdigits(this int i, int n = 1) => i.ToString().Length == n;
        public static bool Is1digit(this int i)  => i <         10 && i > -1;
        public static bool Is2digits(this int i) => i <        100 && i > 9;
        public static bool Is3digits(this int i) => i <       1000 && i > 99;
        public static bool Is4digits(this int i) => i <      10000 && i > 999;
        public static bool Is5digits(this int i) => i <     100000 && i > 9999;
        public static bool Is6digits(this int i) => i <    1000000 && i > 99999;
        public static bool Is7digits(this int i) => i <   10000000 && i > 999999;
        public static bool Is8digits(this int i) => i <  100000000 && i > 9999999;
        public static bool Is9digits(this int i) => i < 1000000000 && i > 99999999;

        private static bool IsN(this int i, int n = 1) => i == n;
        public static bool Is1(this int i) => i.IsN(1);
        public static bool Is2(this int i) => i.IsN(2);
        public static bool Is3(this int i) => i.IsN(3);
        public static bool Is4(this int i) => i.IsN(4);
        public static bool Is5(this int i) => i.IsN(5);
        public static bool Is6(this int i) => i.IsN(6);
        public static bool Is7(this int i) => i.IsN(7);
        public static bool Is8(this int i) => i.IsN(8);
        public static bool Is9(this int i) => i.IsN(9);
        public static bool Is0(this int i) => i.IsN(0);

        public static bool IsEven(this int i) => i % 2 == 0;
        public static bool IsOdd(this int i) => !i.IsEven();
        public static bool IsMultipleOf(this int i, int n) => i % n == 0;
        public static bool IsMultipleOfFive(this int i) => i.IsMultipleOf(5);

        public static int FindNthDigitFromRight(this int i, int n = 1) => (i / (int)Pow(10, n - 1)) % 10;
        public static int Find1stDigit(this int i) => i.FindNthDigitFromRight(1);
        public static int Find2ndDigit(this int i) => i.FindNthDigitFromRight(2);
        public static int Find3rdDigit(this int i) => i.FindNthDigitFromRight(3);
        public static int Find4thDigit(this int i) => i.FindNthDigitFromRight(4);
        public static int Find5thDigit(this int i) => i.FindNthDigitFromRight(5);
        public static int Find_X(this int i) => i.FindNthDigitFromRight(1);
        public static int Find_X1(this int i) => i.FindNthDigitFromRight(2);
        public static int Find_X21(this int i) => i.FindNthDigitFromRight(3);
        public static int Find_X321(this int i) => i.FindNthDigitFromRight(4);
        public static int Find_X4321(this int i) => i.FindNthDigitFromRight(5);

        public static int FindNNthDigitFromRight(this int i, int n = 1) => (i / (int)Pow(10, n - 1)) % 100;

        #region 2digits
        public static bool IsX1(this int i)
        {
            if (!i.Is2digits()) return false;
            return (i % 10).Is1();
        }
        public static bool IsX6(this int i)
        {
            if (!i.Is2digits()) return false;
            return (i % 10).Is6();
        }
        public static bool IsX7(this int i)
        {
            if (!i.Is2digits()) return false;
            return (i % 10).Is7();
        }
        public static bool IsX9(this int i)
        {
            if (!i.Is2digits()) return false;
            return (i % 10).Is9();
        }
        public static bool Is8X(this int i)
        {
            if (!i.Is2digits()) return false;
            return (i / 10).Is8();
        }
        #endregion 2digits
        #region 3digits
        public static bool IsXX2(this int i)
        {
            if (!i.Is3digits()) return false;
            return (i % 10).Is2();
        }
        public static bool IsXX3(this int i)
        {
            if (!i.Is3digits()) return false;
            return (i % 10).Is3();
        }
        public static bool IsXX9(this int i)
        {
            if (!i.Is3digits()) return false;
            return (i % 10).Is9();
        }
        public static bool IsX0X(this int i)
        {
            if (!i.Is3digits()) return false;
            return ((i / 10) % 10).Is0();
        }
        public static bool IsX2X(this int i)
        {
            if (!i.Is3digits()) return false;
            return ((i / 10) % 10).Is2();
        }
        public static bool IsX4X(this int i)
        {
            if (!i.Is3digits()) return false;
            return ((i / 10) % 10).Is4();
        }
        public static bool IsX6X(this int i)
        {
            if (!i.Is3digits()) return false;
            return ((i / 10) % 10).Is6();
        }
        public static bool Is2XX(this int i)
        {
            if (!i.Is3digits()) return false;
            return (i / 100).Is2();
        }
        public static bool Is8XX(this int i)
        {
            if (!i.Is3digits()) return false;
            return (i / 100).Is8();
        }
        #endregion 3digits
        #region 4digits
        public static bool IsXXX3(this int i)
        {
            if (!i.Is4digits()) return false;
            return (i % 10).Is3();
        }
        public static bool IsXXX4(this int i)
        {
            if (!i.Is4digits()) return false;
            return (i % 10).Is4();
        }
        public static bool IsXXX9(this int i)
        {
            if (!i.Is4digits()) return false;
            return (i % 10).Is9();
        }
        public static bool IsXX1X(this int i)
        {
            if (!i.Is4digits()) return false;
            return ((i / 10) % 10).Is1();
        }
        public static bool IsXX3X(this int i)
        {
            if (!i.Is4digits()) return false;
            return ((i / 10) % 10).Is3();
        }
        public static bool IsXX5X(this int i)
        {
            if (!i.Is4digits()) return false;
            return ((i / 10) % 10).Is5();
        }
        public static bool IsXX9X(this int i)
        {
            if (!i.Is4digits()) return false;
            return ((i / 10) % 10).Is9();
        }
        public static bool IsX0XX(this int i)
        {
            if (!i.Is4digits()) return false;
            return ((i / 100) % 10).Is0();
        }
        public static bool IsX1XX(this int i)
        {
            if (!i.Is4digits()) return false;
            return ((i / 100) % 10).Is1();
        }
        public static bool IsX3XX(this int i)
        {
            if (!i.Is4digits()) return false;
            return ((i / 100) % 10).Is3();
        }
        public static bool IsX5XX(this int i)
        {
            if (!i.Is4digits()) return false;
            return ((i / 100) % 10).Is5();
        }
        public static bool IsXX13(this int i)
        {
            if (!i.Is4digits()) return false;
            return (i % 100).IsN(13);
        }
        public static bool Is4XXX(this int i)
        {
            if (!i.Is4digits()) return false;
            return (i / 1000).Is4();
        }
        public static bool Is4XX3(this int i) => i.Is4XXX() && i.IsXXX3();
        public static bool Is9XXX(this int i)
        {
            if (!i.Is4digits()) return false;
            return (i / 1000).Is9();
        }
        public static bool Is9X13(this int i)
        {
            if (!i.Is4digits()) return false;
            if ((i % 100).IsN(13)) return false;
            return (i / 1000).Is9();
        }
        #endregion 4digits
        #region 5digits
        public static bool IsXXXX3(this int i)
        {
            if (!i.Is5digits()) return false;
            return (i % 10).Is3();
        }
        public static bool IsXXXX4(this int i)
        {
            if (!i.Is5digits()) return false;
            return (i % 10).Is4();
        }
        public static bool IsXXX3X(this int i)
        {
            if (!i.Is5digits()) return false;
            return ((i / 10) % 10).Is3();
        }
        public static bool IsXXX7X(this int i)
        {
            if (!i.Is5digits()) return false;
            return ((i / 10) % 10).Is7();
        }
        public static bool IsXX2XX(this int i)
        {
            if (!i.Is5digits()) return false;
            return ((i / 100) % 10).Is2();
        }
        public static bool IsXX3XX(this int i)
        {
            if (!i.Is5digits()) return false;
            return ((i / 100) % 10).Is3();
        }
        public static bool IsXX3X4(this int i) => i.IsXX3XX() && i.IsXXXX4();
        public static bool IsXX4XX(this int i)
        {
            if (!i.Is5digits()) return false;
            return ((i / 100) % 10).Is4();
        }
        public static bool IsX4XXX(this int i)
        {
            if (!i.Is5digits()) return false;
            return ((i / 1000) % 10).Is4();
        }
        #endregion 5digits
        #region 6digits
        public static bool IsXXXXX3(this int i)
        {
            if (!i.Is6digits()) return false;
            return (i % 10).Is3();
        }
        public static bool IsXXXX9X(this int i)
        {
            if (!i.Is6digits()) return false;
            return ((i / 10) % 10).Is9();
        }
        public static bool IsXXXX90(this int i)
        {
            if (!i.Is6digits()) return false;
            return (i % 100).IsN(90);
        }
        public static bool IsXXX8XX(this int i)
        {
            if (!i.Is6digits()) return false;
            return ((i / 100) % 10).Is8();
        }
        public static bool IsXX567X(this int i)
        {
            if (!i.Is6digits()) return false;
            return ((i / 10) % 1000).IsN(567);
        }
        public static bool IsX4XXXX(this int i)
        {
            if (!i.Is6digits()) return false;
            return ((i / 10000) % 10).Is4();
        }
        public static bool IsX3X4XX(this int i)
        {
            if (!i.Is6digits()) return false;
            if (((i / 100) % 10).Is4()) return false;
            return ((i / 10000) % 10).Is3();
        }
        public static bool Is123XXX(this int i)
        {
            if (!i.Is6digits()) return false;
            return (i / 1000).IsN(123);
        }
        #endregion 6digits
        #region 7digits
        public static bool IsXXXXXX2(this int i)
        {
            if (!i.Is7digits()) return false;
            return (i % 10).Is2();
        }
        public static bool IsXXXXX50(this int i)
        {
            if (!i.Is7digits()) return false;
            return (i % 100).IsN(50);
        }
        public static bool IsXXXX1XX(this int i)
        {
            if (!i.Is7digits()) return false;
            return ((i / 100) % 10).Is1();
        }
        public static bool IsXXXX9XX(this int i)
        {
            if (!i.Is7digits()) return false;
            return ((i / 100) % 10).Is9();
        }
        public static bool IsXXXX1X2(this int i) => i.IsXXXX1XX() && i.IsXXXXXX2();
        public static bool IsXXXX7X8(this int i)
        {
            if (!i.Is7digits()) return false;
            if ((i % 10).Is8()) return false;
            return ((i / 100) % 10).Is7();
        }
        public static bool IsXXX4X9X(this int i)
        {
            if (!i.Is7digits()) return false;
            return i.Find2ndDigit() == 9 && i.Find4thDigit() == 4;
        }
        public static bool IsXXX4XX1(this int i)
        {
            if (!i.Is7digits()) return false;
            return i.Find1stDigit() == 1 && i.Find4thDigit() == 4;
        }
        public static bool IsXXX56XX(this int i)
        {
            if (!i.Is7digits()) return false;
            return ((i / 100) % 100).IsN(56);
        }
        public static bool IsXX567XX(this int i)
        {
            if (!i.Is7digits()) return false;
            return ((i / 100) % 1000).IsN(567);
        }
        public static bool IsX12XXXX(this int i)
        {
            if (!i.Is7digits()) return false;
            var douze = (i / 10000) % 100;
            return ((i / 10000) % 100).IsN(12);
        }
        public static bool IsX78XXXX(this int i)
        {
            if (!i.Is7digits()) return false;
            return i.FindNNthDigitFromRight(5) == 78;
        }
        public static bool Is1XXXXXX(this int i)
        {
            if (!i.Is7digits()) return false;
            return i.FindNNthDigitFromRight(7) == 1;
        }
        public static bool Is16XXXXX(this int i)
        {
            if (!i.Is7digits()) return false;
            return i.FindNNthDigitFromRight(6) == 16;
        }
        public static bool Is8XXXXXX(this int i)
        {
            if (!i.Is7digits()) return false;
            return i.FindNNthDigitFromRight(7) == 8;
        }
        public static bool Is8XXX9XX(this int i) => i.Is8XXXXXX() && i.IsXXXX9XX();
        #endregion 7digits
        #region 8digits
        public static bool IsXXX3X8XX(this int i)
        {
            if (!i.Is8digits()) return false;
            return i.Find5thDigit() == 3 && i.Find3rdDigit() == 8;
        }
        public static bool IsXXX5XXXX(this int i)
        {
            if (!i.Is8digits()) return false;
            return i.Find5thDigit() == 5;
        }
        public static bool IsXX2X7XXX(this int i)
        {
            if (!i.Is8digits()) return false;
            return i.FindNthDigitFromRight(6) == 2 && i.Find4thDigit() == 7;
        }
        public static bool IsXX6XX9XX(this int i)
        {
            if (!i.Is8digits()) return false;
            return i.FindNthDigitFromRight(6) == 6 && i.Find3rdDigit() == 9;
        }
        #endregion 8digits
    }
}
