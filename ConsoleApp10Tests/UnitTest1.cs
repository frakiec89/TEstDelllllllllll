using ConsoleApp10;

namespace ConsoleApp10Tests
{
    public class AuthorizationServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("admin", "123")]
        [TestCase("user", "111")]
        [TestCase("petya", "pety")]
        public void IsAutTest_true(string log ,  string pas)
        {
            // подготовка 
            var login = log;
            var password = pas;

            var service = new AuthorizationService();

            // акт 

            bool actual = service.IsAutChek(login, password);

            // ожидание  - реальность

            Assert.IsTrue(actual);
        }


        [TestCase("", "123")]
        [TestCase(" ", "123")]
        [TestCase("admin", " ")]
        [TestCase(null, "111")]
        [TestCase("admin", "")]
        [TestCase("admin", null)]
        [TestCase("null", null)]
        [TestCase("", "")]
        [TestCase("NoName", "123")]
        public void IsAutTest_false(string log, string pas)
        {
            // подготовка 
            var login = log;
            var password = pas;

            var service = new AuthorizationService();

            // акт 

            bool actual = service.IsAutChek(login, password);

            // ожидание  - реальность

            Assert.IsFalse(actual);
        }



    }
}