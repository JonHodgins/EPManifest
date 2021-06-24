using System.Globalization;
using System.Text.RegularExpressions;

namespace EPManifest.App.Extensions
{
    public static class FormInputExtensions
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
