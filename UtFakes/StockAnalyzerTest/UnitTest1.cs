﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VS.UTFakes;

namespace StockAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestContosoStockPrice()
        {
            // Arrange:

            // Create the fake stockFeed:
            IStockFeed stockFeed =
                 new VS.UTFakes.Fakes.StubIStockFeed() // Generated by Fakes.
                 {
                     // Define each method:
                     // Name is original name + parameter types:
                     GetSharePriceString = (company) => { return 1234; }
                 };

            // In the completed application, stockFeed would be a real one:
            var componentUnderTest = new StockAnalyzer(stockFeed);

            // Act:
            int actualValue = componentUnderTest.GetContosoPrice();

            // Assert:http://msdn.microsoft.com/en-us/library/hh549174.aspx
            Assert.AreEqual(1234, actualValue);
        }

    }
}