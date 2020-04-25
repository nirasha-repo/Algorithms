using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1

            // sample data creation
            var numbers = TestDataHelper.GetNumbers(50000);

            // Find largest and smallest numbers from the given array
            Question1.FindLargestAndSmallestNumbers(numbers);

            //----------------------------------------------------------------------

            // Q2

            // sample data creation
            var str = TestDataHelper.GetString(100000000);

            // Best Solution (for a 'string' type of input. i.e. max char limit is 2,147,483,647)
            // O(1) complexity 
            // Works well with large amount of data. 
            // Only single ToArray() method is used.
            Question2.RemoveDuplicateCharacters1(str);

            // Second Best Solution (for a 'string' type of input. i.e. max char limit is 2,147,483,647)
            // O(1) complexity 
            // Works well with large amount of data.
            // Two ToArray() methods and additional Distinct() method are used. 
            Question2.RemoveDuplicateCharacters2(str);

            // Worst solution (for a 'string' type of input. i.e. max char limit is 2,147,483,647)
            // O(N) complexity 
            // Very slow with large amount of data due to looping. 
            Question2.RemoveDuplicateCharacters3(str);

            // Best solution for an extremly large input via a physical text file. ex: Over GB size files.  
            // Assumption : Comparison is done chunk by chunk assuming unique chars will be found after few iterations in real world.  
            // Sample text file (ExtremelyLargeString.txt) is attached in the solution for this test and unique chars will be found 
            // in few early iterations and further file scanning is not required. 
            // Drawback : If all expected unique chars are not found during the early stages of iterations, full iteration will occur.
            Question2.RemoveDuplicateCharacters4();

            //----------------------------------------------------------------------

            // Q3
            
            // Check two strings are Anagrams
            var first = "Listen";
            var second = "Silent";
            var areAnagrams = Question3.AreTwoStringsAnagram(first, second);
            Console.WriteLine($"Q3 => Are {first} and {second} are Anagrams : {areAnagrams}");

            first = "Astronomer";
            second = "Moon starer";
            areAnagrams = Question3.AreTwoStringsAnagram(first, second);
            Console.WriteLine($"Q3 => Are {first} and {second} are Anagrams : {areAnagrams}");

            first = "Australia";
            second = "australia";
            areAnagrams = Question3.AreTwoStringsAnagram(first, second);
            Console.WriteLine($"Q3 => Are {first} and {second} are Anagrams : {areAnagrams}");

            first = "dfdfd hghgh";
            second = "dfgfd hihdh";
            areAnagrams = Question3.AreTwoStringsAnagram(first, second);
            Console.WriteLine($"Q3 => Are {first} and {second} are Anagrams : {areAnagrams}");

            //----------------------------------------------------------------------            

            // Q3
            var mobile = "+61 412 345 678";
            var isValid = Question4.IsValidAustralianMobile(mobile);

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"Q4 => Is {mobile} a valid Australian Mobile No. : {isValid}");

            mobile = "0412 345 678";
            isValid = Question4.IsValidAustralianMobile(mobile);
            Console.WriteLine($"Q4 => Is {mobile} a valid Australian Mobile No. : {isValid}");

            mobile = "+61412345678";
            isValid = Question4.IsValidAustralianMobile(mobile);
            Console.WriteLine($"Q4 => Is {mobile} a valid Australian Mobile No. : {isValid}");

            mobile = "0412345678";
            isValid = Question4.IsValidAustralianMobile(mobile);
            Console.WriteLine($"Q4 => Is {mobile} a valid Australian Mobile No. : {isValid}");

            mobile = "0412-345-678"; // Only numerics and spaces are permitted
            isValid = Question4.IsValidAustralianMobile(mobile);
            Console.WriteLine($"Q4 => Is {mobile} a valid Australian Mobile No. : {isValid} (Only numerics and spaces are permitted)");

            mobile = "+44412345678"; // Not Australian
            isValid = Question4.IsValidAustralianMobile(mobile);
            Console.WriteLine($"Q4 => Is {mobile} a valid Australian Mobile No. : {isValid} (Not Australian)");

            mobile = "1300 500 999"; // Not a mobile number
            isValid = Question4.IsValidAustralianMobile(mobile);
            Console.WriteLine($"Q4 => Is {mobile} a valid Australian Mobile No. : {isValid} (Not a mobile number)");

            mobile = "+61 2 9876 5432"; // Not a mobile number
            isValid = Question4.IsValidAustralianMobile(mobile);
            Console.WriteLine($"Q4 => Is {mobile} a valid Australian Mobile No. : {isValid} (Not a mobile number)");            
        }
    }
}
