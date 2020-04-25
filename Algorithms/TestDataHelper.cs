using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class TestDataHelper
    {
        // Returns a random string of given length
        public static string GetString(int stringLength)
        {
            var rd = new Random();
            const string allowedChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz0123456789!@$?_-&%# ";
            char[] chars = new char[stringLength];

            for (int i = 0; i < stringLength; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }

        // Retuns an Integer array with random numbers for the given size 
        public static List<int> GetNumbers(int size)
        {
            var numbers = new List<int>();
            for (int i = 0; i < size; i++)
            {
                var random = new Random();
                numbers.Add(random.Next(100, 10000));
            }

            return numbers;
        }
    }
}
