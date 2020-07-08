using System;
using System.Collections.Generic;

namespace permutations
{
    public class Permutation
    {
        public static List<string> GenerateAllPermutationsOfAString(int[] arr) {
            return GenerateAllPermutationsOfAString(String.Empty, arr);
        }

        public static List<string> GenPermutation(string word = "", string[] amountOfCharacters) {
            List<string> words = new List<string>();
            Queue<string> queue = new Queue<string>(amountOfCharacters);
            HashSet<string> seen = new HashSet<string>();

            do {
                string character = currentAmountOfCharacter.Pop();
                string newWord = word + character;
                seen.Add(character);

                if (queue.Count == 1) {
                    return new List<string>(newWord);
                }

                while(currentAmountOfCharacter.Count > 0) {
                    var response = GenPermutation(newWord, queue.ToArray());
                    words.AddRange(response);
                    queue.Push(character);
                }
            } while(seen.Count != queue.Count);

            return words;
        }
    }
}