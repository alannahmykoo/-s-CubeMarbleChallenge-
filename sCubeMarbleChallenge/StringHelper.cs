﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCubeMarbleChallenge
{
    public static class StringHelper
    {
        public static string CleanString(string inputString)
        {
            String cleanString = inputString.ToLower();
            char[] testArray = cleanString.ToCharArray();
            StringBuilder builder = new StringBuilder();

            foreach (char c in testArray)
            {
                if (char.IsLetterOrDigit(c))
                {
                    builder.Append(c);
                }
            }
            cleanString = builder.ToString();
           return cleanString;
        }
        public static string ReverseString(string inputString)
        {
          
            char[] testArray = inputString.ToCharArray();
            Array.Reverse(testArray);
            String reverseString = new String(testArray);
            return reverseString;
        }
        public static bool IsPalindrome(string inputString)
        {
            String cleanString = StringHelper.CleanString(inputString); 
            String reverseString = StringHelper.ReverseString(cleanString);
            return cleanString == reverseString;
        }
    }
}
