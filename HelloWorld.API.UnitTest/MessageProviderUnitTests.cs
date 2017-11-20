using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.API.Providers;

namespace HelloWorld.API.UnitTest
{
    [TestClass]
    public class MessageProviderUnitTests
    {
        private static IMessageProvider messageProvider;
        private static string message;
        private static string expectedResult = "Hello World";

        [TestMethod]
        public void ConsoleAppMsgProviderTest()
        {
            messageProvider = new ConsoleAppMsgProvider();
            message = messageProvider.GetMessage();

            Assert.AreEqual(expectedResult, message);
        }

        [TestMethod]
        public void MobileAppMsgProvider()
        {
            messageProvider = new MobileAppMsgProvider();
            message = messageProvider.GetMessage();

            Assert.AreEqual(expectedResult, message);
        }
        
        [TestMethod]
        public void StaticValueMsgProvider()
        {
            messageProvider = new StaticValueMsgProvider();
            message = messageProvider.GetMessage();

            Assert.AreEqual(expectedResult, message);
        }

        [TestMethod]
        public void WebAppMsgProvider()
        {
            messageProvider = new WebAppMsgProvider();
            message = messageProvider.GetMessage();

            Assert.AreEqual(expectedResult, message);
        }

        [TestMethod]
        public void WindowsServiceMsgProvider()
        {
            messageProvider = new WindowsServiceMsgProvider();
            message = messageProvider.GetMessage();

            Assert.AreEqual(expectedResult, message);
        }
    }
}
