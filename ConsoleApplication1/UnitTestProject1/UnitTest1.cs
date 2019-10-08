using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
            bool result3 = Program.IsOdd(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsOdd(4);
            Assert.AreEqual(false, result4);
        }
        [TestMethod]
        public void TestIsEven()
        {
            bool result2 = Program.isEven(2);
            Assert.AreEqual(true, result2);
            bool result1 = Program.isEven(1);
            Assert.AreEqual(false, result1);
        }
    }
}
