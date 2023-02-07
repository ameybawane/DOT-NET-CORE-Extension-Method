using System;

namespace ConvertToInt_ExtensionMethod
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.AsInt("5"));

            Console.ReadKey();
        }

        static int AsInt(this string str)
        {
            int op = (int)Int64.Parse(str);
            return op;
        }
    }
}
