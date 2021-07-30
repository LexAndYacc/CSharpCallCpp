using CSharpDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static CSharpDemo.StructsSumDemo;

namespace LibTest
{
    [TestClass]
    public class StructsSumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            SumOfTwoNumbers[] sumOfTwoNumbers = new SumOfTwoNumbers[]
            {
                new SumOfTwoNumbers()
                {
                    a = 1,
                    b = 2,
                    result = 0
                },
                new SumOfTwoNumbers()
                {
                    a = 3,
                    b = 4,
                    result = 0
                },
            };



            SumOfTwoNumbers[] result = StructsSumDemo.Execte(sumOfTwoNumbers);
            Assert.AreEqual(3, result[0].result);
            Assert.AreEqual(7, result[1].result);
        }
    }
}
