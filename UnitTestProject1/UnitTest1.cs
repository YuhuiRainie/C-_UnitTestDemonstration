using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemonstration;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var sh = new Shapes(4.0);
            Assert.AreEqual(sh.CircleArea(),50.272);

  
        }
    }
}
