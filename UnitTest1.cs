using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Program program;
        public UnitTest1()
        {
            program = new Program();
        }
        [TestMethod]
        public void TestMethod1()
        {
            var result = program.UserRegister("Neha12345");
            Assert.AreEqual("Valid", result);
        }

    }
}
