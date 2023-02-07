using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * the extension method concept allows you to add new methods in the 
 * existing class or in the structure without modifying the source 
 * code of the original type and you do not require any kind of 
 * special permission from the original type and there is no need 
 * to re-compile the original type. It is introduced in C# 3.0.
 * 
 * Suppose you have a class or a structure which contains three methods 
 * and you want to add two new methods in this class or structure, you did not have 
 * the source code of the class/structure, or do not have permissions from the 
 * class/structure, or the class is a sealed class, but you still want to add new 
 * methods in it, then you can use the concept extension method to add the new method 
 * in the existing class/structure. Now you create a new class which is static and 
 * contain the two methods which you want to add in the existing class, now bind this 
 * class with the existing class. After binding you will see the existing class can 
 * access the two new added methods.
 * 
 * https://www.geeksforgeeks.org/extension-method-in-c-sharp/#:~:text=In%20C%23%2C%20the%20extension%20method,re%2Dcompile%20the%20original%20type.
 */
namespace ExtensionMethodDemo
{
    // Geek class access all the five methods
    internal class Program
    {
        public static void Main(string[] args)
        {
            Geek g = new Geek();
            g.M1();
            g.M2();
            g.M3();
            g.M4();
            g.M5("Method Name: M5");

            Console.ReadKey();
        }
    }
}
