using System;
using System.Collections.Generic;

namespace graphs.keys_and_rooms
{
    public class KeysAndRooms
    {
        public static bool canVisitAllRooms(List<List<int>> rooms) {
            Queue<int> queue = new Queue<int>();
            HashSet<int> seen = new HashSet<int>();

            // init the queye, therefore, we need to make room 0 as seen
            queue.Enqueue(0);
            seen.Add(0);

            while(queue.Count > 0) {
                int currentRoom = queue.Dequeue();
                List<int> keys = rooms[currentRoom];
                foreach(int key in keys) {
                    if (!seen.Contains(key)){
                        queue.Enqueue(key);
                        seen.Add(key);
                    }
                }
            }

            return rooms.Count == seen.Count;
        } 
    }
}