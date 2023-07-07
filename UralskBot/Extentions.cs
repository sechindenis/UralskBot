using System.Text.RegularExpressions;

namespace UralskBot
{
    public static class Extentions
    {
        public static string RemoveWhiteSpaces(this string str)
        {
            return Regex.Replace(str, @"\s+", string.Empty);
        }
    }
}