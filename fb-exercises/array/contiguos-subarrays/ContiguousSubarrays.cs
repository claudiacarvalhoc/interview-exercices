using System;
using System.Collections.Generic;

class ContiguousSubarrays {
  
  static Stack<int> stack = new Stack<int>();
  
  static void Main(string[] args) {
    var result = countSubarrays(new int[]{3,4,1,6,2});
    for(int i=0;i<result.Length;++i)
      Console.Write($"{result[i]},");
  }
  
  private static int[] countSubarrays(int[] arr) {
    int[] left = BuildLeft(arr);
    stack.Clear();
    int[] right = BuildRight(arr);
    int[] result = new int[arr.Length];
    
    for(int i=0;i<arr.Length;++i)
    {
      result[i] = left[i] + right[i] + 1; //max left + max right + current element
    }
    
    return result;
  }
  
  private static int[] BuildLeft(int[] arr)
  {
    int[] left = new int[arr.Length];
    for(int i=0;i<arr.Length;++i)
    {
      while(stack.Count > 0 && arr[stack.Peek()] < arr[i])
      {
        //Size of largest subarray to the left of popped element + the popped element itself
        left[i] += left[stack.Pop()] + 1;
      }
      stack.Push(i);
    }
    return left;
  } 
  
  private static int[] BuildRight(int[] arr)
  {
    int[] right = new int[arr.Length];
    for(int i=arr.Length-1;i>=0;--i)
    {
      while(stack.Count > 0 && arr[stack.Peek()] < arr[i])
      {
        //Size of largest subarray to the right of popped element + the popped element itself
        right[i] += right[stack.Pop()] + 1;
      }
      stack.Push(i);
    }
    return right;
  } 
}

/**

int[] countSubarrays(int[] arr) {
    Stack<Integer> stack = new Stack<>();
    int[] ans = new int[arr.length];
    for(int i = 0; i < arr.length; i++) {
      while(!stack.isEmpty() && arr[stack.peek()] < arr[i]) {
        ans[i] += ans[stack.pop()];
      }
      stack.push(i);
      ans[i]++;
    }
     stack.clear();
    int[] temp = new int[arr.length];
     for(int i = arr.length - 1; i >= 0; i--) {
      while(!stack.isEmpty() && arr[stack.peek()] < arr[i]) {
        int idx = stack.pop();
        ans[i] += temp[idx];
        temp[i] += temp[idx];
      }
      stack.push(i);
      temp[i]++;
    }
    return ans;
  }


**/