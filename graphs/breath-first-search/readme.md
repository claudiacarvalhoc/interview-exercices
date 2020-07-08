Breadth First Search:
* Search the full connected component of the node it starts on
* Go "wide", expanding layer by layer from the start node (because of the nature of how we add nodes that are next to be visited)

The Breadth-first search algorithm:
* Use a Queue - FIFO structure
* We will visit a node
* Add all the items to the queue
* The first element to came is the first to come in
* We go out layer by layer
* We GARANTEE that we find the SHORTEST PATH
* Most used on problems as: Regions / Areas / Paint Regions


The following I will write the iterations and steps to go thought all nodes of graph using BFS algorithm.

Based on picture "example.ong" the algorithm would be:

// all structure start empty

queue: []
seen: []
output: []

// add A to queue
queue: [A]
seen: [A]
output: []

// add A to the output and remove it from queue
// process A
// search for adjacent nodes
// A -> B
// A -> J
// A -> G
// none of items has been seen, so all the items will be added to the queue
queue: [B,J,G]
seen: [A,B,J,G]
output: [A]

// add B to the output and remove it from queue
// process B
// search for adjacent nodes
// B -> D
// B -> A
// A of items has been seen, so only D will be added to the queue
queue: [J,G,D]
seen: [A,B,J,G,D]
output: [A, B]

// add J to the output and remove it from queue
// process J
// add J adjacent nodes
// J -> G and J -> D and J -> A - all itens as been seen, so none of the items will be added to the queue
queue: [G,D]
seen: [A,B,J,G,D]
output: [A, B, J]

// add G to the output and remove it from queue
// process G
// add G adjacent nodes
// G -> J 
// G -> A
// G -> F
// G -> E
// only F and E will be added to the queue
queue: [D,F,E]
seen: [A,B,J,G,D,F,E]
output: [A, B, J, G]


// add D to the output and remove it from queue
// process D
// add D adjacent nodes
// D -> B
// D -> J
// D -> H
// only H will be added to the queue
queue: [F,E,H]
seen: [A,B,J,G,D,F,E,H]
output: [A, B, J, G, D]


// add F to the output and remove it from queue
// process F
// add F adjacent nodes
// F -> G
// F -> E
// F -> I
// F -> H
// only H will be added to the queue
queue: [E,H,I]
seen: [A,B,J,G,D,F,E,H,I]
output: [A, B, J, G, D, F]


// add E to the output and remove it from queue
// process E
// add E adjacent nodes
// E -> G
// E -> F
// E -> I
// all itens as been seen, so none of the items will be added to the queue
queue: [H,I]
seen: [A,B,J,G,D,F,E,H,I]
output: [A, B, J, G, D, F, E]

// add H to the output and remove it from queue
// process H
// add H to outpur and search for adjacent nodes
// H -> D
// H -> F
// E -> I
// E -> C
// only C will be added to the queue
queue: [I,C]
seen: [A,B,J,G,D,F,E,H,I, C]
output: [A, B, J, G, D, F, E, H]

// add I to the output and remove it from queue
// process I
// add I to outpur and search for adjacent nodes
// I -> E
// I -> F
// I -> H
// all itens as been seen, so none of the items will be added to the queue
queue: [C]
seen: [A,B,J,G,D,F,E,H,I,C]
output: [A, B, J, G, D, F, E, H, I]


// add C to the output and remove it from queue
// process C
// add C to outpur and search for adjacent nodes
// C -> H
// all itens as been seen, so none of the items will be added to the queue
queue: []
seen: [A,B,J,G,D,F,E,H,I,C]
output: [A, B, J, G, D, F, E, H, I, C]

Time and Space complexity:
Time: O(|V|+|E|)
Space: O(|V|)

|X| -> amount of X, for V and E, would be - amount of vertices and amount of edges

V - vertices
E - Edges