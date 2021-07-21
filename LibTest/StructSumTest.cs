using CSharpDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static CSharpDemo.StructSumDemo;

namespace LibTest
{
    [TestClass]
    public class StructSumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            SumOfTwoNumbers sumOfTwoNumbers = new SumOfTwoNumbers()
            {
                a = 1,
                b = 2,
                result = 0
            };

            StructSumDemo.Execte(ref sumOfTwoNumbers);
            Assert.AreEqual(3, sumOfTwoNumbers.result);
        }
    }
}
