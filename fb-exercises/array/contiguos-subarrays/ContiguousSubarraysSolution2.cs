using System;
using System.Collections.Generic;

public class ContiguousSubarraysSolution2
{
    int[] countSubarrays(int[] arr)
    {
		int[] output = new int[arr.Length];

		for (int i = 0; i < arr.Length; ++i) {
			output[i] = 
				recursiveSubArraysCounter(arr, new List<int>(), 0, i, false) + 
				recursiveSubArraysCounter(arr, new List<int>(), i, arr.Length - 1, true) + 
				1;
		}

		return output;
    }


	int recursiveSubArraysCounter(int[] arr, List<List<int>> subset, int index, int start, int end, bool directionRight) {
		if ((directionRight && index > end) || (!directionRight && index < start)) {
			return subset.Count;
		}
		
		List<int> subset_2 = new List<int>();
		if (!directionRight) {
			subset_2.Add(arr[index]);
			subset_2.AddRange(subset[subset.Count]);
		} else {
			subset_2.AddRange(subset[subset.Count]);
			subset_2.Add(arr[index]);
		}
		subset.Add(subset_2);

		int nextIndex = directionRight ? index + 1 : index -1;
		
		return recursiveSubArraysCounter(arr, subset, nextIndex, start, end, directionRight);
	}
}