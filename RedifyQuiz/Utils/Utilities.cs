using System;
using System.Linq;
using System.Web;

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
        public static string ReverseWords(string s)
        {
            string sentence = HttpUtility.HtmlEncode(s);
            var reversedWords = string.Join(" ", sentence.Split(' ')
                .Select(x => new String(x.Reverse().ToArray())));
            reversedWords = HttpUtility.HtmlDecode(reversedWords);
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
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return "Error";
            }
            if (((b + c) <= a) || ((a + c) <= b) || ((a + b) <= c))
            {
                return "Error";
            }

            if ((Math.Abs(b - c) >= a) || (Math.Abs(a - c) >= b) || (Math.Abs(a - b) >= c))
            {
                return "Error";
            }

            //check if all sides are equal
            if (a == b && a == c)
            {
                return "Equilateral";
            }

            //check if any two sides are equal
            if (a == b || a == c || b == c)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }

        }

    }
}