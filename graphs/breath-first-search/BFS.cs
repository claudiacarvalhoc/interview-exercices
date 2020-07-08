using System;
using System.Collections.Generic;

namespace graphs.breath_first_search
{
    public class BFS
    {
        public static HashSet<int> BFS_Implementation(List<List<int>> nodes) {
            Queue<int> queue = new Queue<int>();
            HashSet<int> seen = new HashSet<int>();

            // init the queye, therefore, we need to make room 0 as seen
            queue.Enqueue(0);
            seen.Add(0);

            while(queue.Count > 0) {
                int currentRoom = queue.Dequeue();
                // each vertices has N adjacent vertices, ie, edges
                foreach(int node in nodes[currentRoom]) {
                    // if node was not been seen, then, we must add it to the queue
                    // and mark as seen
                    if (!seen.Contains(node)){
                        queue.Enqueue(node);
                        seen.Add(node);
                    }
                }
            }

            return seen;
        }
    }
}