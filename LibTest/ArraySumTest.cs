using CSharpDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibTest
{
    [TestClass]
    public class ArraySumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(6, ArraySumDemo.Execte(new int[] { 1,2,3}));
        }
    }
}
