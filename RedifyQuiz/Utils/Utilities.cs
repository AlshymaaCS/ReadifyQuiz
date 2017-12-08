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
    }
}