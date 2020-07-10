using System;

namespace primitives.add_strings
{
    public class SumStrings
    {
        public string addStrings(string s1, string s2)
        {
            // We use the ascii code to get the substract the code and find the
            // int value
            char zero = '0';
            string output = "";

            int length = Math.Max(s1.Length, s2.Length);
            int carry = 0;

            // The idea here is iterate each char from last char to the first char
            for (int i = 0; i < length; ++i) {

                // Get the ascii code for each char
                // If s1 or s2 do not has chars to read, we must use the default int - 0
                int s1_code = (s1.Length - 1) - i >= 0 ? s1[i] : zero;
                int s2_code = (s2.Length - 1) - i >= 0 ? s2[i] : zero;

                // Get the number that is presented on char, by
                // subtract each char with 0 ascii code
                int decimal_s1_char = s1_code - zero;
                int decimal_s2_char = s2_code - zero;

                // Sum each decimal value + carry
                int sum = decimal_s1_char + decimal_s2_char + carry;

                // Print the right digit to the string
                output = sum % 10 + output;

                // Update carry to be used on the iteration
                carry = carry + sum / 10;
            }

            // If carry has a value left
            // we need to include it on result
            // Example:
            ///   11        -> carry
            //      9       -> s1
            //  +  99       -> s2
            //  _______
            //    108       -> total sum
            if (carry > 0) {
                output = carry + output;
            }

            return output;
        }
    }
}