using System;
using System.Collections.Generic;

namespace array
{
    public class ListPrimeNumbers
    {
        public static void Run() {
            int number = 23;
            PrintPrimes(number, EnumeratePrimes(number));

            number = 2;
            PrintPrimes(number, EnumeratePrimes(number));

            number = 9;
            PrintPrimes(number, EnumeratePrimes(number));

            number = 1;
            PrintPrimes(number, EnumeratePrimes(number));
        }

        public static List<int> EnumeratePrimes(int number) {
            if (number < 2) {
                return new List<int>();
            }

            List<int> prime = new List<int>() { 2 };
            for (int i = 3; i <= number; i = i + 2) {
                bool isPrime = true;
                for  (int divider = 2; divider < i; divider++) {
                    if (i % divider == 0) {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime) {
                    prime.Add(i);
                }
            }

            return prime;
        }

        public static void PrintPrimes(int number, List<int> primes) {
            Console.WriteLine($"Input: {number}");
            Console.WriteLine($"Output: [ {String.Join(", ", primes)} ]\n");            
        }
    }
}