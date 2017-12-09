using RedifyQuiz.Utils;
using System;
using System.Web.Http;

namespace RedifyQuiz.Controllers
{

    public class QuizController : ApiController
    {
        /// <summary>
        /// Gets readify token
        /// </summary>
        /// <returns>Token string</returns>
        [Route("api/Token")]
        [HttpGet]
        public IHttpActionResult GetToken()
        {
            return Ok("13e75793-25bc-409f-9fe7-c65498762140");
        }


        /// <summary>
        /// Gets the nth number in the fibonacci sequence.
        /// </summary>
        /// <returns>integer</returns>
        [Route("api/Fibonacci")]
        [HttpGet]
        public IHttpActionResult GetFibonacci(string n)
        {
            long nth;
            if (long.TryParse(n, out nth))
            {

                try
                {
                    if (nth < 93 && nth > -93) //the largest known fib
                        return Ok(Utilities.NthFibonacciNumber(nth));
                    else
                        return BadRequest();
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }
            else
            {
                return BadRequest("The request is invalid.");
            }
        }


        /// <summary>
        /// Reverses the letters of each word in a sentence.
        /// </summary>
        /// <returns>integer</returns>
        [Route("api/ReverseWords")]
        [HttpGet]
        public IHttpActionResult GetReversedWords(string sentence)
        {
            try
            {
                return Ok(Utilities.ReverseWords(sentence));
            }
            catch (Exception)
            {
                return BadRequest("The request is invalid.");
            }
        }

        /// <summary>
        /// Returns the type of triange given the lengths of its sides
        /// </summary>
        /// <returns>string</returns>
        [Route("api/TriangleType")]
        [HttpGet]
        public IHttpActionResult GetTriangleType(int a, int b, int c)
        {
            try
            {
                return Ok(Utilities.TriangleType(a, b, c));
            }
            catch (Exception)
            {
                return BadRequest("The request is invalid.");
            }
        }


    }
}
