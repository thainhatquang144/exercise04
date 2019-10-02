using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCeil()
        {
            int result1=Program.Ceil((float)2.3);
            Assert.AreEqual(3,result1);
            int result2=Program.Ceil(-2.5f);
            Assert.AreEqual(-2, result2);
        }
        public void Testfloor()
        {
            int result1 = Program.floor((float)2.3);
            Assert.AreEqual(3, result1);
            int result2 = Program.floor(-2.5f);
            Assert.AreEqual(-2, result2);
        }
        public void TestSquare()
        {
            int result1 = Program.Square(2);
            Assert.AreEqual(4, result1);
            int result2 = Program.Square(3);
            Assert.AreEqual(9, result2);
        }
        public void Testcube()
        {
            int result1 = Program.cube(2);
            Assert.AreEqual(8, result1);
            int result2 = Program.cube(3);
            Assert.AreEqual(-27, result2);
        }
        public void Testabs()
        {
            int result1 = Program.abs(2);
            Assert.AreEqual(2, result1);
            int result2 = Program.abs(-2);
            Assert.AreEqual(2, result2);
        }
        public void testPow9()
        {
            int result1 = Program.Pow(3,3);
            Assert.AreEqual(27,result1);
        }
        public void testPrime()
        {
            bool result1 = Program.IsPrime(13);
            Assert.AreEqual(true,result1);
            bool result2 = Program.IsPrime(10);
            Assert.AreEqual(false, result2);
        }
        public void testfactorial()
        {
            long result = Program.Factorial(3);
            Assert.AreEqual(6, result);
        }
    }
}
