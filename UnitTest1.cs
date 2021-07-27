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
            var result = program.UserRegister("Jagtapneha1212@gmail.com");
            Assert.AreEqual("Valid", result);
        }

    }
}
