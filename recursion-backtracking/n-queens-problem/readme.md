The N Queens Problem
Given an input integer n, generate all n x n boards with n non-attacking queens placed.

A queen q1 is "attacking" another queen q2 if ;
q2 sits in the same row as q1
q2 sits in the same column as q1
q2 sits in the diagonal reach of q1

Attacking Arrangement:
[
 "-Q--",
 "-Q--",
 "Q---",
 "--Q-"
]

Explanation:
- Queen in row 0 is attacking queen in row 1 column-wise.
- Queen in row 2 is attacking queen in row 1 diagonally.

Example:
Input: 4

Output:
[
 [
  "-Q--",
  "---Q",
  "Q---",
  "--Q-"
 ],
 [
  "--Q-",
  "Q---",
  "---Q",
  "-Q--"
 ]
]

Explanation: There are only 2 4x4 board arrangements of 4 non-attacking queens

Constraints:
1 <= n <= 10
