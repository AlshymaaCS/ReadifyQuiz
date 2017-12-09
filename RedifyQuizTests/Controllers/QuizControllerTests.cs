using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http;
using System.Web.Http.Results;

namespace RedifyQuiz.Controllers.Tests
{
    [TestClass()]
    public class QuizControllerTests
    {
        [TestMethod()]
        public void GetTokenTest()
        {
            QuizController ctr = new QuizController();
            IHttpActionResult res = ctr.GetToken();
            var contentResult = res as OkNegotiatedContentResult<string>;

            Assert.IsNotNull(contentResult);
            Assert.AreEqual("13e75793-25bc-409f-9fe7-c65498762140", contentResult.Content);
        }

        [TestMethod()]
        public void GetFibonacciTestForPositiveNumber()
        {
            QuizController ctr = new QuizController();
            IHttpActionResult res = ctr.GetFibonacci("10");
            var contentResult = res as OkNegotiatedContentResult<long>;

            Assert.IsNotNull(contentResult);
            Assert.AreEqual(55, contentResult.Content);
        }

        [TestMethod()]
        public void GetFibonacciTestForNegativeNumber()
        {
            QuizController ctr = new QuizController();
            IHttpActionResult res = ctr.GetFibonacci("-10");
            var contentResult = res as OkNegotiatedContentResult<long>;

            Assert.IsNotNull(contentResult);
            Assert.AreEqual(-55, contentResult.Content);
        }

        [TestMethod()]
        public void GetFibonacciTestForVerylargeNumber()
        {
            QuizController ctr = new QuizController();
            IHttpActionResult res = ctr.GetFibonacci("-1000");
            var contentResult = res as BadRequestResult;

            Assert.IsNotNull(contentResult);
        }

        [TestMethod()]
        public void GetFibonacciTestForInputString()
        {
            QuizController ctr = new QuizController();
            IHttpActionResult res = ctr.GetFibonacci("sss");
            var contentResult = res as BadRequestErrorMessageResult;

            Assert.IsNotNull(contentResult);
        }

        [TestMethod()]
        public void GetReversedWordsTestForNormalSentence()
        {
            QuizController ctr = new QuizController();
            IHttpActionResult res = ctr.GetReversedWords("I am here because i want to be");
            var contentResult = res as OkNegotiatedContentResult<string>;

            Assert.IsNotNull(contentResult);
            Assert.AreEqual("I ma ereh esuaceb i tnaw ot eb", contentResult.Content);
        }


        [TestMethod()]
        public void GetReversedWordsTestForDoubleSpaces()
        {
            QuizController ctr = new QuizController();
            IHttpActionResult res = ctr.GetReversedWords("I    am    here because i want to be");
            var contentResult = res as OkNegotiatedContentResult<string>;

            Assert.IsNotNull(contentResult);
            Assert.AreEqual("I    ma    ereh esuaceb i tnaw ot eb", contentResult.Content);
        }

        [TestMethod()]
        public void GetTriangleTypeTestForIsosceles()
        {
            QuizController ctr = new QuizController();
            IHttpActionResult res = ctr.GetTriangleType(10, 10, 5);
            var contentResult = res as OkNegotiatedContentResult<string>;

            Assert.IsNotNull(contentResult);
            Assert.AreEqual("Isosceles", contentResult.Content);
        }

        [TestMethod()]
        public void GetTriangleTypeTestForScalene()
        {
            QuizController ctr = new QuizController();
            IHttpActionResult res = ctr.GetTriangleType(10, 20, 15);
            var contentResult = res as OkNegotiatedContentResult<string>;

            Assert.IsNotNull(contentResult);
            Assert.AreEqual("Scalene", contentResult.Content);
        }

        [TestMethod()]
        public void GetTriangleTypeTestForEquilateral()
        {
            QuizController ctr = new QuizController();
            IHttpActionResult res = ctr.GetTriangleType(10, 10, 10);
            var contentResult = res as OkNegotiatedContentResult<string>;

            Assert.IsNotNull(contentResult);
            Assert.AreEqual("Equilateral", contentResult.Content);
        }

        [TestMethod()]
        public void GetTriangleTypeTestForNegativeInput()
        {
            QuizController ctr = new QuizController();
            IHttpActionResult res = ctr.GetTriangleType(-10, 10, 10);
            var contentResult = res as OkNegotiatedContentResult<string>;

            Assert.IsNotNull(contentResult);
            Assert.AreEqual("Error", contentResult.Content);
        }


        [TestMethod()]
        public void GetTriangleTypeTestForInvalidTriangle()
        {
            QuizController ctr = new QuizController();
            IHttpActionResult res = ctr.GetTriangleType(1, 2, 3);
            var contentResult = res as OkNegotiatedContentResult<string>;

            Assert.IsNotNull(contentResult);
            Assert.AreEqual("Error", contentResult.Content);
        }


    }
}