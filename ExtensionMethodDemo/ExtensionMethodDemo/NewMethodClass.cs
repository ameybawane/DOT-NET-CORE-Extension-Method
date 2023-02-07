using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// C# program to illustrate the concept
// of the extension methods
namespace ExtensionMethodDemo
{
    // This class contains M4 and M5 method
    // Which we want to add in Geek class.
    // NewMethodClass is a static class
    static class NewMethodClass
    {

        // Method 4
        public static void M4(this Geek g)
        {
            Console.WriteLine("Method Name: M4");
        }

        // Method 5
        public static void M5(this Geek g, string str)
        {
            Console.WriteLine(str);
        }
    }
}
