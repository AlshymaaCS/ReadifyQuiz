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
        public string GetToken()
        {
            return "13e75793-25bc-409f-9fe7-c65498762140";
        }


    }
}
