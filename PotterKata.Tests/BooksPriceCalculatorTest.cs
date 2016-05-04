using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PotterKata.Tests
{
    [TestClass]
    public class BooksPriceCalculatorTest
    {
        [TestMethod]
        public void CalculateBookPrices_Book_1_Return_100()
        {
            BookPriceCalculator target = new BookPriceCalculator();
            List<int> boughtBooks = new List<int>();
            int expected = 100;

            int actual = target.CalculatePrice(boughtBooks);

            Assert.AreEqual(expected, actual);
        }
    }
}
