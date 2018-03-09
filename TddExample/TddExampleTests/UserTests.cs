using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddExample;

namespace TddExampleTests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void GetColorTest()
        {
            IUser user = new User();
            Assert.AreEqual("mgregory", user.GetUserId());
        }
    }
}