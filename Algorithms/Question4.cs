using System.Text.RegularExpressions;

namespace Algorithms
{
    public static class Question4
    {
        // Assumption : Only below two formats are valid. Spaces are permitted anywhere.
        // +61412345678 OR 0412345678 
        public static bool IsValidAustralianMobile(string mobile)
        {
            // Removing white spaces with Regex            
            mobile = Regex.Replace(mobile, @"\s+", "");

            // To check Australian mobile phone number
            var rgx = new Regex("(^(([+]614)|(04))\\d{8}$)");

            var isValid = rgx.IsMatch(mobile);

            return isValid;
        }
    }
}
