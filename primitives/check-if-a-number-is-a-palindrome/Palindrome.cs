using System;

namespace primitives
{
    public class Palindrome
    {
        /*
            Time: O(N) - linear time
            Space: N * 2 - constant time
            N is the number of digits of int
        */
        public bool isPalindrome_Solution1(int value)
        {
            // A negative number is not a palindrome
            if (value < 0) {
                return false;
            }

            int original = value;
            int reverse = 0;

            // while the value is greater then 0
            // we will have digits to process
            while (value >= 0) {
                // Get last digit of integer
                int digit = value % 10;
                // Sum the digit to reverse integer
                reverse = (reverse * 10) + digit;
                // Remove the last digit from value integer
                value = value / 10;
            }

            // the number is a palindrome
            // if the original integer is equal to the reverse integer
            return original == reverse;
        }

        /*
            Time: O(N/2) - half of linear time
            Space: N * 2 - constant time
            N is the number of digits of int
        */
        public bool isPalindrome_Solution2(int value)
        {
            if (value < 0) {
                return false;
            }

            // using the base 10 logarithm to:
            // - get the number of digits 
            // - get the left mask to extract left digit
            double log10 = Math.Log10(value);
            int numberOfDigits = (int) log10 + 1;
            int leftMask = (int) Math.Pow(10, log10);
            int rightMask = 10;

            for (int i = 1; i <= numberOfDigits / 2; ++i) {
                int rightDigit = value % rightMask;
                int leftDigit = value / leftMask;
                leftMask = leftMask / 10;

                if (leftDigit != rightDigit) {
                    return false;
                }
            }

            return true;
        }
    }
}