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
            var result = program.UserRegister("9465336523");
            Assert.AreEqual("Valid", result);
        }

    }
}
