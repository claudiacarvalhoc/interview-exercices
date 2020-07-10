using System;

namespace primitives.power_of_two
{
    public class PowerOfTwo
    {

        /**
            Time and Space Complexity:
            Time: O(1)
            Space: O(1)
        */
        public bool isPowerOfTwo_Solution1(int input) {
            return (input > 0 && (input & (input - 1)) == 0);
        }

        /**
            Time and Space Complexity:
            Time: O(1)
            Space: O(1)
        */
        public bool isPowerOfTwo_Solution2(int input) {
            return Math.Sqrt(input) % 2 == 0;
        }
    }
}