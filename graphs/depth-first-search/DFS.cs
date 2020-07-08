using System;
using System.Collections;
using System.Collections.Generic;

namespace graphs.depth_first_search
{
    public class DFS
    {
        public static HashSet<int> DFS_Implementation(List<List<int>> nodes) {
            Stack<int> stack = new Stack<int>();
            HashSet<int> seen = new HashSet<int>();

            // init the stack, therefore, we need to make room 0 as seen
            stack.Push(0);
            seen.Add(0);

            while(stack.Count > 0) {
                int currentRoom = stack.Pop();
                // each vertices has N adjacent vertices, ie, edges
                foreach(int node in nodes[currentRoom]) {
                    // if node was not been seen, then, we must add it to the stack
                    // and mark as seen
                    if (!seen.Contains(node)){
                        stack.Push(node);
                        seen.Add(node);
                    }
                }
            }

            return seen;
        }
    }
}