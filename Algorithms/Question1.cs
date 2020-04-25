using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static class Question1
    {
        // Here I have used inbuilt Min & Max functions as they are much faster than
        // sorting the list and get the first/last elements from the list OR
        // looping through the list and compare each element with previously found min/max values        
        public static void FindLargestAndSmallestNumbers(List<int> numbers)
        {
            Console.WriteLine("");
            var startTime = DateTime.Now;
            Console.WriteLine($"Q1 => Min : {numbers.Min()} and Max : {numbers.Max()}");
            var timeTaken = DateTime.Now.Subtract(startTime).TotalMilliseconds;
            Console.WriteLine("");
            Console.WriteLine($"Time Taken : {timeTaken} ms");
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
