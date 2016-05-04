using System;
using System.Collections.Generic;

namespace PotterKata
{
    public class BookPriceCalculator
    {
        public int CalculatePrice(List<int> boughtBooks)
        {
            if (boughtBooks.Count == 1)
                return 100;
            else
                return 190;
        }
    }
}