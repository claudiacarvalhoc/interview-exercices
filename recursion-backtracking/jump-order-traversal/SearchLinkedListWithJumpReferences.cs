using System;
using System.Collections.Generic;

namespace recursion_backtracking.jump_order_traversal
{
    public class SearchLinkedListWithJumpReferences
    {
        public static void Run() {

        }

        public static void setJumpOrder_2(Node node, List<Node> output) {
            if (node != null && node.Order == -1) {
                node.Order = output.Count + 1;
                output.Add(node);
                JumpAlgoritm(node.Jump, output);
                JumpAlgoritm(node.Next, output);
            }
        }

        public static void setJumpOrder(Node node, int order) {
            if (node == null || node.Order == -1) {
                return null;
            }
            
            node.Order = order;
            order++;
            setJumpOrder(node.Jump, output);
            setJumpOrder(node.Next, output);

            // Time and Complexity
            // Time: O(n)
            // Space: O(n)
        }

         public Node setJumpOrder(Node head) {
            /*
            We can model the Depth First Search with our own stack
            (instead of the call stack).
            */
            Stack<Node> stack = new Stack<Node>();

            int currentOrder = 0;
            stack.push(head);

            while (!stack.isEmpty()) {
            Node node = stack.pop();

            if (node != null && node.order == -1) {
                node.order = currentOrder;

                currentOrder += 1;

                // Priority goes to the jump node, we push it last.
                // It will be popped first next iteration to be searched on.
                stack.push(node.next);
                stack.push(node.jump);
            }
            }

            return head;

            // Time and Complexity
            // Time: O(n)
            // Space: O(n)
        }
    }

    public class Node {
        public string Name { get; set; }
        public int Order { get; set; } = -1;
        public Node Jump { get; set; }
        public Node Next { get; set; }
    }
}