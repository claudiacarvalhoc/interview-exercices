using System;
using System.Collections.Generic;

namespace fb_exercises.queues.queue_removals
{
    public class RemovalQueues
    {
        public int[] findPositions(int[] arr, int x) {
            Queue<int> queue = new Queue<int>(arr);

            while (queue.Count > x) { // O(N2)
                int[] sub_arr = GetElements(queue, x); // O(N)
                
                int largestElementIndex = GetIndexLasgestElement(sub_arr); // O(N)
                int [] arr_to_queue = new int[sub_arr.Length - 1];
                for (int i = 0; i < sub_arr.Length; ++i) { // O(N)
                    if (i != largestElementIndex) {
                        int value = sub_arr[i] > 0 ? sub_arr[i] + 1 : sub_arr[i];
                        int index = i < largestElementIndex ? i : i + 1;
                        arr_to_queue[index] = value;
                    }
                }
                
                QueueElements(queue, arr_to_queue); // O(N)
            }
            
            return queue.ToArray();
        }

        public int[] GetElements(Queue<int> queue, int count) {
            int[] arr = new int[count];
            
            for (int i = 0; i < count; ++i) {
                int value = queue.Dequeue();
                arr[i] = value;
            }

            return arr;
        }

        public void QueueElements(Queue<int> queue, int[] arr) {
            for (int i = 0; i < arr.Length; ++i) {
                queue.Enqueue(arr[i]);
            }
        }

        public int GetIndexLasgestElement(int[] arr) {
            int largestNumberIndex = 0;
            int largestNumber = Int32.MinValue;
            
            for (int i = 0; i < arr.Length; ++i) {
                if (arr[i] > largestNumber) {
                    largestNumber = arr[i];
                    largestNumberIndex = i;
                }
            }

            return largestNumberIndex;
        }
    }
}