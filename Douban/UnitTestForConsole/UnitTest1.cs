using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using System.Reflection;

namespace UnitTestForConsole
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            PrivateType a = new PrivateType(typeof(A));
            int a1= (int)a.InvokeStatic("f");
            Assert.AreEqual(1, a1);
        }
    }
}