using System;
using System.Linq;

namespace RedifyQuiz.Utils
{
    public class Utilities
    {
        /// <summary>
        /// Gets nth Fibonacci Number
        /// </summary>
        /// <param name="n"></param>
        /// <returns>integer</returns>
        public static int NthFibonacciNumber(int n)
        {
            int a = 0;
            int b = 1;
            while (n-- > 1)
            {
                int t = a;
                a = b;
                b += t;
            }
            return b;
        }

        /// <summary>
        /// Reverses the letters of each word in a sentence.
        /// </summary>
        /// <returns>integer</returns>
        public static string ReverseWords(string sentence)
        {
            var reversedWords = string.Join(" ", sentence.Split(' ').Select(x => new String(x.Reverse().ToArray())));
            return reversedWords;
        }
    }
}