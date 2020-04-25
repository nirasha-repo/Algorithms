using System;

namespace Algorithms
{
    public static class Question3
    {
        // Assumption : Inputs are fitting into string variables  
        // ex: 'Listen' = 'Silent' OR 'Astronomer' = 'Moon starer'
        public static bool AreTwoStringsAnagram(string first, string second)
        {
            first = first.Replace(" ", "");
            second = second.Replace(" ", "");

            if (first.Length != second.Length)
            {
                return false;
            }

            first = first.ToUpper();
            second = second.ToUpper();

            // same word or phrase (case insensitive) cannot be Anagrams
            if (first == second)
            {
                return false;
            }

            var firstCharArr = first.ToCharArray();
            var secondCharArr = second.ToCharArray();

			// complexity -> O(NlogN)
            Array.Sort(firstCharArr);
            Array.Sort(secondCharArr);

            return (new string(firstCharArr) == new string(secondCharArr));
        }
    }
}
