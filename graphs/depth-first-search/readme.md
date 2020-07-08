Depth-first search will:
* Search the full connected component of the node it starts on
* Go "deep", naturally following paths from the start node



The following I will write the iterations and steps to go thought all nodes of graph using DFS algorithm.

Based on picture "example.ong" the algorithm would be:

// all structure start empty

stack: bottom [] top
seen: []
output: []

// add A to stack
stack: bottom [A] top
seen: [A]
output: []

// add A to the output and remove it from stack
// process A
// search for adjacent nodes
// A -> B
// A -> J
// A -> G
// none of items has been seen, so all the items will be added to the stack
stack: bottom [B,J,G] top
seen: [A,B,J,G]
output: [A]

// add G to the output and remove it from stack
// process G
// search for adjacent nodes
// G -> A
// G -> J
// G -> F
// G -> E
// A of items has been seen, so only D will be added to the stack
stack: bottom [B,J] top
seen: [A,B,J,G]
output: [A, G]

// add J to the output and remove it from stack
// process J
// add J adjacent nodes
// J -> G and J -> D and J -> A - all itens as been seen, so none of the items will be added to the stack
stack: [G,D]
seen: [A,B,J,G,D]
output: [A, B, J]

// add G to the output and remove it from stack
// process G
// add G adjacent nodes
// G -> J 
// G -> A
// G -> F
// G -> E
// only F and E will be added to the stack
stack: [D,F,E]
seen: [A,B,J,G,D,F,E]
output: [A, B, J, G]


// add D to the output and remove it from stack
// process D
// add D adjacent nodes
// D -> B
// D -> J
// D -> H
// only H will be added to the stack
stack: [F,E,H]
seen: [A,B,J,G,D,F,E,H]
output: [A, B, J, G, D]


// add F to the output and remove it from stack
// process F
// add F adjacent nodes
// F -> G
// F -> E
// F -> I
// F -> H
// only H will be added to the stack
stack: [E,H,I]
seen: [A,B,J,G,D,F,E,H,I]
output: [A, B, J, G, D, F]


// add E to the output and remove it from stack
// process E
// add E adjacent nodes
// E -> G
// E -> F
// E -> I
// all itens as been seen, so none of the items will be added to the stack
stack: [H,I]
seen: [A,B,J,G,D,F,E,H,I]
output: [A, B, J, G, D, F, E]

// add H to the output and remove it from stack
// process H
// add H to outpur and search for adjacent nodes
// H -> D
// H -> F
// E -> I
// E -> C
// only C will be added to the stack
stack: [I,C]
seen: [A,B,J,G,D,F,E,H,I, C]
output: [A, B, J, G, D, F, E, H]

// add I to the output and remove it from stack
// process I
// add I to outpur and search for adjacent nodes
// I -> E
// I -> F
// I -> H
// all itens as been seen, so none of the items will be added to the stack
stack: [C]
seen: [A,B,J,G,D,F,E,H,I,C]
output: [A, B, J, G, D, F, E, H, I]


// add C to the output and remove it from stack
// process C
// add C to outpur and search for adjacent nodes
// C -> H
// all itens as been seen, so none of the items will be added to the stack
stack: []
seen: [A,B,J,G,D,F,E,H,I,C]
output: [A, B, J, G, D, F, E, H, I, C]

Time and Space Complexity
Time: O(|V|+|E|)
Space: O(|V|)

|X| -> amount of X, for V and E, would be - amount of vertices and amount of edges

V - vertices
E - Edges