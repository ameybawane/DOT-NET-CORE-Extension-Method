using System;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExtensionClass.str = "9";
            int ToIntResult = ExtensionClass.str.AsInt();
            Console.WriteLine(ToIntResult);

            ExtensionClass.str = "true";
            bool ToBollResult = ExtensionClass.str.AsBool();
            Console.WriteLine(ToBollResult);

            ExtensionClass.str = "49.6a";
            float ToFloatResult = ExtensionClass.str.AsFloat();
            Console.WriteLine(ToFloatResult);

            ExtensionClass.str = "0.999";
            decimal ToDecimalResult = ExtensionClass.str.AsDecimal();
            Console.WriteLine(ToDecimalResult);

            DateTime today = DateTime.Today;
            ExtensionClass.str = "xyz";
            DateTime ToDateTimeResult = ExtensionClass.str.AsDateTime();
            Console.WriteLine(ToDateTimeResult);

            Console.ReadKey();
        }
    }
}
