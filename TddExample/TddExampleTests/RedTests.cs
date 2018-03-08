using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddExample;

namespace TddExampleTests
{
    [TestClass()]
    public class RedTests
    {
        [TestMethod()]
        public void GetColorTest()
        {
            IColor color = new Red();
            Assert.AreEqual("red", color.GetColor());
        }
    }
}