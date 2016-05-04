﻿using System;
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
            var target = new BookPriceCalculator();
            List<int> boughtBooks = new List<int>{ 1 };
            int expected = 100;

            int actual = target.CalculatePrice(boughtBooks);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateBookPrices_Book_1_2_Return_190()
        {
            var target = new BookPriceCalculator();
            List<int> boughtBooks = new List<int> { 1, 2 };
            int expected = 190;

            int actual = target.CalculatePrice(boughtBooks);

            Assert.AreEqual(expected, actual);
        }
    }
}
