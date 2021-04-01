using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ExtensionMethods.ChangeCase("test case change"));
            Console.WriteLine(ExtensionMethods.ChangeToTitleCase("title case"));
            Console.WriteLine(ExtensionMethods.IsLowerOrUpper("test"));
            Console.WriteLine(ExtensionMethods.Capitalize("capitalise string"));
            Console.WriteLine(ExtensionMethods.NumericValue("1234567890"));
            Console.WriteLine(ExtensionMethods.RemoveLastCharacter("remove"));
            Console.WriteLine(ExtensionMethods.WordCount("count words"));
            Console.WriteLine(ExtensionMethods.StringToInteger("11111"));
            Console.ReadKey();
        }

       
    }
}
