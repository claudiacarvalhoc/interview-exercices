using System;
using System.Collections.Generic;

namespace linked_lists.reverse_operations
{
    public class ReverseOperations
    {
        public Node reverse(Node head) {
            Node current = head;
            // The stack will have the even elements
            // when the current node is null or a odd number  
            // we should pop each element redirect each next 
            // to the correct element
            Stack<Node> stack = new Stack<Node>();
            Node reverseStartPoint = null;

            // current point to the element that is being processed
            while(current != null) {
                
                // when element is odd, is added to the stack
                if (isEvenNode(current.data)) {
                    stack.Push(current);
                } else {
                    reverseStartPoint = current;
                }
                
                // we need to clean the stack and redirect each node
                if (shouldReverse(current) && stack.Count > 0) {
                    
                    if (reverseStartPoint == null) {
                        // If List is: 2,4,6,8 the reverseStartPoint will be null
                        // Therefore, we need to set it to the element 8
                        // ie - the last added element into the stack
                        reverseStartPoint = stack.Pop();
                        reverseStartPoint.Next = stack.Count > 0 ? stack.Peek() : null;
                        // In this scenario, the head is pointing to
                        // the end of list or the middle
                        // Therefore, we need to redirect the head to the element
                        // that is in the top of stack
                        head = reverseStartPoint;
                    }

                    while (stack.Count > 0) {
                        Node even = stack.Pop();

                        // If stack still has elements
                        // we need to point to the top of he stack
                        if (stack.Count > 0) {
                            even.Next = stack.Peek();
                        }
                        // When we have a list as: 2,4,6,8
                        // The current element is 2, ie, that means that we must set next as null
                        // Otherwise, we would set a circular reference to the list
                        else {
                            even.Next = isEvenNode(current.data) ? current : null;
                        }
                    }
                }

                // Move to the next element
                current = current.Next;
            }

            // return the first element 
            return head;
        }

        public bool isEvenNode(int data) => data % 2 == 0;

        public bool shouldReverse(Node node) {
            return !isEvenNode(node.data) || node.Next == null;
        }
    }


    public class Node {
        public Node Next { get; set; }
        public int data { get; set; }
    }
}