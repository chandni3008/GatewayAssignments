using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestingAssignment2
{
   public static class ExtensionMethods
    {
        public static string ChangeCase(this string inputString)
        {
            if (Char.IsLower(inputString[0]))
            {
                return inputString.ToUpper();

            }

            else
            {
                return inputString.ToLower();
            }

        }

        public static string ChangeToTitleCase(this string inputString)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(inputString);

        }

        public static bool LowerCaseString(this string inputString)
        {
            bool Lower = true;
            for (int index = 0; index < inputString.Length; index++)
            {
                if (Char.IsUpper(inputString[index]))
                {
                    Lower = false;
                    break;
                }
            }
            return Lower ? true : false;
        }

        public static bool UpperCaseString(this string inputString)
        {
            bool Upper = true;
            for (int index = 0; index < inputString.Length; index++)
            {
                if (Char.IsLower(inputString[index]))
                {
                    Upper = false;
                    break;
                }
            }
            return Upper ? true : false;
        }

        public static string Capitalize(this string inputString)
        {
            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(inputString);
        }

        public static bool NumericValue(this string inputString)
        {
            return int.TryParse(inputString, out int n);
        }

        public static string RemoveLastCharacter(this string inputString)
        {
            return inputString.Remove(inputString.Length - 1);
        }

        public static int WordCount(this string inputString)
        {
            return inputString.Split(' ').Length;
        }

        public static int StringToInteger(this string inputString)
        {
            int.TryParse(inputString, out int n);
            return n;
        }
    }

    
}
