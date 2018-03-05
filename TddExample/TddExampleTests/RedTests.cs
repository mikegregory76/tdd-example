using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddExample.Tests
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