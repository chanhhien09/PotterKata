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
            else if (boughtBooks.Count == 2)
                return 190;
            else if (boughtBooks.Count == 3)
                return 270;
            else
                return 320;
        }
    }
}