using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Algorithms
{
    public static class Question2
    {
        // removes duplicate characters from string
        // Please Note, max length for the string is Int32 (i.e. 2,147,483,647)
        public static void RemoveDuplicateCharacters1(string str)
        {
            Console.WriteLine("");
            var startTime = DateTime.Now;

            var characters = new HashSet<char>(str).ToArray();
            var deDupStr = new string(characters);

            Console.WriteLine($"Q2 => Method 1 => String without duplicate chars : {deDupStr}");
            var timeTaken = DateTime.Now.Subtract(startTime).TotalMilliseconds;
            Console.WriteLine("");
            Console.WriteLine($"Time Taken : {timeTaken} ms");
            Console.WriteLine("---------------------------------------------------------");
        }

        // removes duplicate characters from string
        // Please Note, max length for the string is Int32 (i.e. 2,147,483,647)
        public static void RemoveDuplicateCharacters2(string str)
        {
            Console.WriteLine("");
            var startTime = DateTime.Now;

            var characters = str.ToCharArray().Distinct().ToArray();
            var deDupStr = new string(characters);

            Console.WriteLine($"Q2 => Method 2 => String without duplicate chars : {deDupStr}");
            var timeTaken = DateTime.Now.Subtract(startTime).TotalMilliseconds;
            Console.WriteLine("");
            Console.WriteLine($"Time Taken : {timeTaken} ms");
            Console.WriteLine("---------------------------------------------------------");
        }


        // removes duplicate characters from string
        // Please Note, max length for the string is Int32 (i.e. 2,147,483,647)
        public static void RemoveDuplicateCharacters3(string str)
        {
            Console.WriteLine("");
            var startTime = DateTime.Now;

            string deDupStr = "";
            foreach (char character in str)
            {
                if (deDupStr.IndexOf(character) == -1)
                {
                    deDupStr += character;
                }
            }

            Console.WriteLine($"Q2 => Method 3 => String without duplicate chars : {deDupStr}");
            var timeTaken = DateTime.Now.Subtract(startTime).TotalMilliseconds;
            Console.WriteLine("");
            Console.WriteLine($"Time Taken : {timeTaken} ms");
            Console.WriteLine("---------------------------------------------------------");
        }

        // removes duplicate characters from an extremly large object (GB scale)
        // Assumption : input string will only have alphabetical characters
        public static void RemoveDuplicateCharacters4()
        {
            Console.WriteLine("");
            var startTime = DateTime.Now;

            const string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var chunkSize = 1000;
            var buffer = new char[chunkSize];
            var uniqueCharsFound = new List<char>();

            var filePath = AppDomain.CurrentDomain.BaseDirectory + "ExtremelyLargeString.txt";
            using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    using (StreamReader sr = new StreamReader(bs))
                    {
                        while (sr.ReadBlock(buffer, 0, chunkSize) > 0)
                        {
                            uniqueCharsFound.AddRange(buffer.Distinct().Except(uniqueCharsFound).Intersect(allowedChars.ToList()));

                            if (uniqueCharsFound.Count == allowedChars.Length)
                            {
                                break;
                            }
                        }
                    }
                }
            }

            var deDupStr = new string(uniqueCharsFound.ToArray());

            Console.WriteLine($"Q1 => Method 4 => String without duplicate chars : {deDupStr}");
            var timeTaken = DateTime.Now.Subtract(startTime).TotalMilliseconds;
            Console.WriteLine("");
            Console.WriteLine($"Time Taken : {timeTaken} ms");
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
