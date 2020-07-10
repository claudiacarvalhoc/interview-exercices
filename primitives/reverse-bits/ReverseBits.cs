using System;

namespace primitives.reverse_bits
{
    public class ReverseBits
    {
        public int reverseBits_Solution1(int input)
        {
            string binaryString = Convert.ToString(input);
            string reverseBinaryString = "";

            for (int i = binaryString.Length - 1; i >= 0; --i) {
                reverseBinaryString += binaryString[i];
            }

            return Convert.ToDecimal(reverseBinaryString);
        }

        /**
            Time and Space Complexity
            Time: O(N) - linear time
            Space: N * 2 - constant time
            N - the number of bits
        */
        public int reverseBits_Solution2(int input)
        {
            int output = 0;
            
            while (input != 0) {
                // shift to the left to have space to fill the next bit
                output = output << 1;

                // if current bit is 1
                // we want to add it in the end
                if ((input & 1 ) == 1) {
                    output = output | 1;
                }

                // since we process this bit
                // we will shift it to the right
                input = input >> 1;
            }

            return output;
        }
    }
}