using System;
using System.Collections.Generic;

namespace fb_exercises.queues.queue_removals
{
    public class RemovalQueuesSolution2
    {

        public int[] findPositions(int[] arr, int count)
        {
            Stack<int> indexLargestValues = new Stack<int>(GetSortedArray(arr, count)); // O(N2)
            for(int n = count; n < arr.Length; ++n) // O(X)
            {
                int largestElementIndex = indexLargestValues.Pop();
                for (int i = 0; i < count; ++i) { // O(X)
                    if (i != largestElementIndex) {
                        int value = arr[i] > 0 ? arr[i] + 1 : arr[i];
                        int index = i < largestElementIndex ? i : i + 1;
                    }
                }
                arr = shiftArrayToRight(arr, 0, count, arr[n]); // O(X)
                InsertElementOnStack(indexLargestValues, arr, n, largestElementIndex); // 2 x O(X)
            }

            return arr;
        }

        public void InsertElementOnStack(Stack<int> stack, int[] arr, int nextIndex, int removedIndex) {
            Stack<int> temp = new Stack<int>();
            while (stack.Count != 0) {
                int index = stack.Pop();
                temp.Push(index > removedIndex ? index - 1 : index);
            }

            while (temp.Count != 0) {
                int index = temp.Pop();
                if (arr[index] > arr[nextIndex]) {
                    stack.Push(index);
                } else {
                    stack.Push(nextIndex);
                    stack.Push(index);
                }
            }
        }

        public int[] shiftArrayToRight(int[] arr, int index, int count, int value) {
            for (int i = index; i < count - 1; ++i) {
                arr[i] = arr[i + 1];
            }
            arr[count-1] = value;
            return arr;
        }

        public int[] GetSortedArray(int[] arr, int count)
        {
            int[] sortedValues = new int[count];
            int[] sortedIndexes = new int[count];
            for (int i = 0; i < count; ++i)
            {
                sortedValues[i] = arr[i];
                sortedIndexes[i] = i;
            }


            for (int i = 1; i < sortedValues.Length; ++i)
            {
                int value = sortedValues[i];
                int j = i - 1;

                for (; j >= 0 && arr[j] >= value; j--)
                {
                    sortedValues[j + 1] = sortedValues[j];
                    sortedIndexes[j + 1] = sortedIndexes[j];
                }
                sortedValues[j + 1] = value;
                sortedIndexes[j + 1] = sortedIndexes[i];
            }

            return sortedIndexes;
        }

        void sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && arr[j] >= key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }



    }

}