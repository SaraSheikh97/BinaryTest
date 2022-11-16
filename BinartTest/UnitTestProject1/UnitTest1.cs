using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BinartTest;
using BinartTest.BinaryClass;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBinary4()
        {
            BinaryConverter p = new BinaryConverter();
            string expected = "100";
            string actual = p.IntToBinaryString(4);
            Assert.AreEqual(expected, actual);
        }
    }
}
