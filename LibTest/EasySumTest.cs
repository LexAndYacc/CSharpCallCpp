using CSharpDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibTest
{
    [TestClass]
    public class EasySumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, EasySumDemo.EasySum(1, 2));
        }
    }
}
