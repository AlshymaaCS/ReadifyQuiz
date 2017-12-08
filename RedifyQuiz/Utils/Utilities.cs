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

        /// <summary>
        /// Returns the type of triange given the lengths of its sides
        /// </summary>
        /// <param name="a">side a</param>
        /// <param name="b">side b</param>
        /// <param name="c">side c</param>
        /// <returns></returns>
        internal static string TriangleType(int a, int b, int c)
        {
            int count = 0;
            if (a - b != 0) count++;
            if (b - c != 0) count++;
            if (c - a != 0) count++;

            var types = new[] { "equilateral", "Error", "isoceles", "scalene" };

            return types[count];
        }
    }
}