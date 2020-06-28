using System;

namespace array
{

/**
    Reverse to Make Equal
    Given two arrays A and B of length N, determine if there is a way to make A equal to B by reversing any subarrays from array B any number of times.
    Signature
    bool areTheyEqual(int[] arr_a, int[] arr_b)
    Input
    All integers in array are in the range [0, 1,000,000,000].
    Output
    Return true if B can be made equal to A, return false otherwise.
    Example
    A = [1, 2, 3, 4]
    B = [1, 4, 3, 2]
    output = true
    After reversing the subarray of B from indices 1 to 3, array B will equal array A.


    // Solution:
    //   - both arrays must have the same lenght
    //   - the ocurrencies of each element must be the same
    //   - the array is not ordered! - this means that we binary search is not an option
    //   - 
*/

    public static class ReverseToMakeEqual
    {
        public static void Entry() {
            Console.WriteLine("ReverseToMakeEqual");
            
            Console.WriteLine("SHOULD RETURN TRUE");

            int[] arr_a1 = new int[] { 1,2,3,4 };
            int[] arr_b2 = new int[] { 1,4,3,2 };
            ReverseToMakeEqual.Run(arr_a1, arr_b2);
            
            arr_a1 = new int[] { 1,2,3,4 };
            arr_b2 = new int[] { 1,2,3,4 };
            ReverseToMakeEqual.Run(arr_a1, arr_b2);

            arr_a1 = new int[] { 4,3,2,1 };
            arr_b2 = new int[] { 1,2,3,4 };
            ReverseToMakeEqual.Run(arr_a1, arr_b2);

            Console.WriteLine("SHOULD RETURN FALSE");

            arr_a1 = new int[] { 4,3,2 };
            arr_b2 = new int[] { 1,2,3,4 };
            ReverseToMakeEqual.Run(arr_a1, arr_b2);

            arr_a1 = new int[] { 4,3,2,6 };
            arr_b2 = new int[] { 1,2,3,4 };
            ReverseToMakeEqual.Run(arr_a1, arr_b2);

            arr_a1 = new int[] {1, 2, 3, 4};
            arr_b2 = new int[] {1, 4, 3, 3};
            ReverseToMakeEqual.Run(arr_a1, arr_b2);
        }
        public static bool Run(int[] arr_a, int [] arr_b)
        {
            Console.WriteLine("========================");
            
            bool result = arr_a.Length != arr_b.Length ? false : ApplyReverse(arr_a, arr_b);
            Console.WriteLine($"arr_a {string.Join(string.Empty, arr_a)}");
            Console.WriteLine($"arr_b {string.Join(string.Empty, arr_b)}");
            Console.WriteLine($"Result {result}");

            return result;
        }

        private static bool ApplyReverse(int[] arr_a, int [] arr_b) {
            // If arrays do not have the same lenght they cannot be equal
            if(arr_a.Length != arr_b.Length) {
                return false;
            }
            // Iterate array A, when value of arr_a[i] match with arr_b[j] the i is incremented
            // If value of arr_a[i] is not found on arr_b , the method return false
            for (int i = 0; i < arr_a.Length; ++i) {
                int j = 0;
                for (; j < arr_b.Length; ++j) {
                    if (arr_a[i] == arr_b[j] && i != j) {
                        int aux = arr_b[i];
                        arr_b[i] = arr_b[j];
                        arr_b[j] = aux;
                        break;
                    } else if (arr_a[i] == arr_b[j] && i == j) {
                        break;
                    }
                }
                // If value of arr_a[i] is not present on arr_b, that means that arr_a and arr_b cannot be equal
                if (j == arr_b.Length) {
                    return false;
                }
            }
            return true;
        }
    }
}
