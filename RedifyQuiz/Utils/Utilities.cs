using System;
using System.Linq;

namespace RedifyQuiz.Utils
{
    public class Utilities
    {
        /// <summary>
        /// Gets nth Fibonacci Number
        /// </summary>
        /// <param name="n"> nth number</param>
        /// <returns>integer</returns>
        public static long NthFibonacciNumber(long n)
        {
            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   
            if (n > 0) return PositiveFib(n);
            else return NegativeFib(n);

        }
        //Fn = Fn − 1 + Fn − 2
        private static long PositiveFib(long n, long one = 1, long zero = 0)
        {
            if (n == 0) return zero;
            if (n == 1) return one;
            return PositiveFib(n - 1, one + zero, one);
        }


        //F(n − 2) = F(n) − F(n − 1)
        private static long NegativeFib(long n, long one = 1, long zero = 0)
        {
            if (n == 0) return zero;
            if (n == 1) return one;

            return NegativeFib(n + 1, zero - one, one);
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

            var types = new[] { "Equilateral", "Error", "Isosceles", "Scalene" };

            return types[count];
        }
    }
}