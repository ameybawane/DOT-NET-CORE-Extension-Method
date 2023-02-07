using System;

namespace ExtensionMethods
{
    static class ExtensionClass
    {
        public static string str = null;
        public static int AsInt(this string str)
        {
            int result;
            bool isOk = Int32.TryParse(str, out result);
            if (isOk)
            {
                return result;
            }
            return 0;
        }
        public static bool AsBool(this string str)
        {
            bool result;
            bool isOk = Boolean.TryParse(str, out result);
            if (isOk)
            {
                return result;
            }
            return false;
        }
        public static float AsFloat(this string str)
        {
            float result;
            bool isOk = float.TryParse(str, out result);
            if (isOk)
            {
                return result;
            }
            return 0;
        }
        public static decimal AsDecimal(this string str)
        {
            decimal result;
            bool isOk = Decimal.TryParse(str, out result);
            if (isOk)
            {
                return result;
            }
            return 0;
        }
        public static DateTime AsDateTime(this string str)
        {
            DateTime result;
            bool isOk = DateTime.TryParse(str, out result);
            if (isOk)
            {
                return result;
            }
            return DateTime.Parse("01/01/0001 00:00:00");
        }
    }
}
