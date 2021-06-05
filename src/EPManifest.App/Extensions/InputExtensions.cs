using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EPManifest.App.Extensions
{
    public static class InputExtensions
    {
        private static readonly TextInfo s_textInfo = new CultureInfo("en-CA", false).TextInfo;

        public static string ToTitleCase(this string str)
        {
            return s_textInfo.ToTitleCase(str);
        }

        public static string FormatPostalCode(this string str)
        {
            var newStr = str.ToUpper();
            const string PostalCodeWithoutSpace = @"^[A-Z]\d[A-Z]\d[A-Z]\d$";
            if (Regex.IsMatch(newStr, PostalCodeWithoutSpace))
            {
                return newStr.Insert(3, " ");
            }
            return str;
        }
    }
}
