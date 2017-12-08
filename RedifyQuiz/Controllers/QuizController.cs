﻿using RedifyQuiz.Utils;
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
            double nth;
            if (double.TryParse(n, out nth))
            {
                return Ok(Utilities.NthFibonacciNumber(nth));
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
            return Ok(Utilities.ReverseWords(sentence));
        }

        /// <summary>
        /// Returns the type of triange given the lengths of its sides
        /// </summary>
        /// <returns>string</returns>
        [Route("api/TriangleType")]
        [HttpGet]
        public IHttpActionResult GetTriangleType(int a, int b, int c)
        {
            return Ok(Utilities.TriangleType(a, b, c));
        }


    }
}
